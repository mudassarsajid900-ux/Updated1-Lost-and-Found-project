/**
 * @file ClaimService.cs
 * @description Manages the lifecycle of ownership claims for found items.
 * Implements a high-integrity verification protocol that automatically resolves 
 * forensic matches and rejects conflicting claims upon an administrator's approval.
 */
using AutoMapper;
using GAC.Application.Helper;
using GAC.Application.Interfaces.ClaimRequests;
using GAC.Application.Interfaces.Shared;
using GAC.Application.Services.ClaimRequests.Dtos;
using GAC.Common.Responce;
using GAC.Core.Entities.Claims;
using GAC.Core.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using GAC.Core.Entities.Item;

namespace GAC.Application.Services.ClaimRequests
{
    public class ClaimService : IClaimService
    {
        private readonly IGenericRepository<ClaimRequest> _claimRepository;
        private readonly IGenericRepository<Items> _itemRepository;
        private readonly IGenericRepository<ItemMatch> _matchRepository;
        private readonly IMapper _mapper;
        private readonly UserData _userData;

        public ClaimService(
            IGenericRepository<ClaimRequest> claimRepository,
            IGenericRepository<Items> itemRepository,
            IGenericRepository<ItemMatch> matchRepository,
            IMapper mapper,
            UserData userData)
        {
            _claimRepository = claimRepository;
            _itemRepository = itemRepository;
            _matchRepository = matchRepository;
            _mapper = mapper;
            _userData = userData;
        }

        /// <summary>
        /// Submits a new ownership claim for a found item.
        /// Includes validation to prevent duplicate claims and ensure the target item 
        /// is still available for processing.
        /// </summary>
        public async Task<Response<GetClaimDto>> SubmitClaimAsync(CreateClaimDto dto)
        {
            // 1. Availability Guard: Verify the found item exists and is in the correct lifecycle state
            var foundItem = await _itemRepository.GetByIdAsync(dto.FoundItemId);
            if (foundItem == null) 
                return Response<GetClaimDto>.NotFoundResponse();

            if (foundItem.Status != ItemStatus.Found)
            {
                string message = foundItem.Status == ItemStatus.Auction 
                    ? "This item has moved to Auction and is no longer available for standard claims." 
                    : "This item is currently in the Replacement pool.";
                return Response<GetClaimDto>.SetCustomErrorResponse(message, StatusCodes.Status400BadRequest);
            }

            // 2. Integrity Guard: Prevent duplicate claims from the same student for the same pairing
            var existingClaim = await _claimRepository.AsQueryable()
                .FirstOrDefaultAsync(x => x.LostItemId == dto.LostItemId && x.FoundItemId == dto.FoundItemId);
            
            if (existingClaim != null)
                return Response<GetClaimDto>.SetCustomErrorResponse("You have already submitted a claim for this item.", StatusCodes.Status400BadRequest);

            var entity = new ClaimRequest
            {
                LostItemId = dto.LostItemId,
                FoundItemId = dto.FoundItemId,
                Status = ClaimStatus.VerificationPending,
                Score = 0,
                CreatedBy = _userData.UserId,
                CreatedOn = DateTime.UtcNow
            };

            await _claimRepository.AddAsync(entity);

            var result = _mapper.Map<GetClaimDto>(entity);
            return Response<GetClaimDto>.SetSuccessResponse(result, "Claim submitted successfully", StatusCodes.Status201Created);
        }

        /// <summary>
        /// Transitions the status of a claim based on administrator verification.
        /// Feature: Auto-Resolution Protocol. When a claim is approved (Succeeded), the system:
        /// 1. Resolves the forensic match.
        /// 2. Resolves all other potential matches for this found item to prevent 'Ghost Matches'.
        /// 3. Rejects all other pending claims for this item with a professional notification.
        /// 4. Moves both items into 'Handover' status for final release.
        /// </summary>
        public async Task<Response<GetClaimDto>> UpdateClaimStatusAsync(UpdateClaimStatusDto dto)
        {
            var entity = await _claimRepository.GetByIdAsync(dto.ClaimId);
            if (entity == null)
                return Response<GetClaimDto>.NotFoundResponse();

            entity.Status = dto.Status;
            entity.RejectionReason = dto.RejectionReason;
            await _claimRepository.UpdateAsync(entity);

            // Trigger the Auto-Resolution Protocol if a final decision (Pass/Fail) is reached
            if (dto.Status == ClaimStatus.VerificationSucceeded || dto.Status == ClaimStatus.VerificationFailed)
            {
                // AUDIT: Using a dedicated transaction to ensure Step A-D happen atomically.
                // This prevents race conditions where multiple claims could be "approved" simultaneously.
                using var transaction = await _itemRepository.BeginTransactionAsync();
                try
                {
                    // Protocol Step A: Resolve THE specific match that was just adjudicated
                    var specificMatch = await _matchRepository.AsQueryable()
                        .FirstOrDefaultAsync(m => (m.LostItemId == entity.LostItemId && m.FoundItemId == entity.FoundItemId));
                    
                    if (specificMatch != null)
                    {
                        specificMatch.IsMatchResolved = true;
                        await _matchRepository.UpdateAsync(specificMatch);
                    }

                    if (dto.Status == ClaimStatus.VerificationSucceeded)
                    {
                        // Protocol Step B: Resolve ALL OTHER matches linked to this Found item (Cleanup)
                        var otherMatches = await _matchRepository.AsQueryable()
                            .Where(m => (m.FoundItemId == entity.FoundItemId || m.LostItemId == entity.LostItemId) && !m.IsMatchResolved)
                            .ToListAsync();
                        
                        foreach (var m in otherMatches)
                        {
                            m.IsMatchResolved = true;
                            await _matchRepository.UpdateAsync(m);
                        }

                        // Protocol Step C: Cascade Rejection. Formally reject other pending claims as the item is resolved.
                        var otherClaims = await _claimRepository.AsQueryable()
                            .Where(c => c.FoundItemId == entity.FoundItemId && c.Id != entity.Id && c.Status == ClaimStatus.VerificationPending)
                            .ToListAsync();

                        foreach (var otherClaim in otherClaims)
                        {
                            otherClaim.Status = ClaimStatus.VerificationFailed;
                            otherClaim.RejectionReason = "Item has been successfully reclaimed by another verified owner.";
                            await _claimRepository.UpdateAsync(otherClaim);
                        }

                        // Protocol Step D: Final Status Transition (Ready for Physical Handover)
                        var foundItem = await _itemRepository.GetByIdAsync(entity.FoundItemId);
                        var lostItem = await _itemRepository.GetByIdAsync(entity.LostItemId);

                        if (foundItem == null || foundItem.Status == ItemStatus.Handover)
                        {
                            await transaction.RollbackAsync();
                            return Response<GetClaimDto>.SetCustomErrorResponse("State Conflict: This item has already been handed over or is unavailable.", StatusCodes.Status400BadRequest);
                        }

                        if (foundItem != null)
                        {
                            foundItem.Status = ItemStatus.Handover;
                            await _itemRepository.UpdateAsync(foundItem);
                        }
                        if (lostItem != null)
                        {
                            lostItem.Status = ItemStatus.Handover;
                            await _itemRepository.UpdateAsync(lostItem);
                        }
                    }

                    await transaction.CommitAsync();
                }
                catch
                {
                    await transaction.RollbackAsync();
                    throw; // Propagate to global trace handler
                }
            }

            var result = _mapper.Map<GetClaimDto>(entity);
            return Response<GetClaimDto>.SetSuccessResponse(result, "Claim status updated successfully");
        }

        public async Task<Response<GetClaimDto>> GetByIdAsync(long id)
        {
            var entity = await _claimRepository.GetByIdAsync(id);
            if (entity == null)
                return Response<GetClaimDto>.NotFoundResponse();

            // Privacy Guard (IDOR protection): Ensures students cannot view claim outcomes of other recipients.
            if (_userData != null && !_userData.Roles.Contains("Admin") && entity.CreatedBy != _userData.UserId)
            {
                return Response<GetClaimDto>.SetCustomErrorResponse("Access Denied: You do not have permission to view this claim.", StatusCodes.Status403Forbidden);
            }

            var result = _mapper.Map<GetClaimDto>(entity);
            return Response<GetClaimDto>.SetSuccessResponse(result);
        }

        public async Task<Response<List<GetClaimDto>>> GetMyClaimsAsync()
        {
            var claims = await _claimRepository.AsQueryable()
                .Where(x => x.CreatedBy == _userData.UserId)
                .ToListAsync();

            var result = _mapper.Map<List<GetClaimDto>>(claims);
            return Response<List<GetClaimDto>>.SetSuccessResponse(result);
        }

        public async Task<Response<List<GetClaimDto>>> GetAllClaimsAsync()
        {
            var claims = await _claimRepository.AsQueryable().ToListAsync();
            var result = _mapper.Map<List<GetClaimDto>>(claims);
            return Response<List<GetClaimDto>>.SetSuccessResponse(result);
        }
    }
}
