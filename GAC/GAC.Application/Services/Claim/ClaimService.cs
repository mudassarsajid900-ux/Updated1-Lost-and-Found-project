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

        public async Task<Response<GetClaimDto>> SubmitClaimAsync(CreateClaimDto dto)
        {
            // 1. Verify Item Status
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

            // 2. Prevent Duplicate Claims
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
                ClaimDescription = dto.Description, // NEW: Capture the user's proof narrative
                CreatedBy = _userData.UserId,
                CreatedOn = DateTime.UtcNow
            };

            await _claimRepository.AddAsync(entity);

            var result = _mapper.Map<GetClaimDto>(entity);
            return Response<GetClaimDto>.SetSuccessResponse(result, "Claim submitted successfully", StatusCodes.Status201Created);
        }

        public async Task<Response<GetClaimDto>> UpdateClaimStatusAsync(UpdateClaimStatusDto dto)
        {
            var entity = await _claimRepository.GetByIdAsync(dto.ClaimId);
            if (entity == null)
                return Response<GetClaimDto>.NotFoundResponse();

            entity.Status = dto.Status;
            entity.RejectionReason = dto.RejectionReason;
            await _claimRepository.UpdateAsync(entity);

            // AUTO-RESOLVE MATCH AND MOVE TO HANDOVER UPON ADMN DECISION
            if (dto.Status == ClaimStatus.VerificationSucceeded || dto.Status == ClaimStatus.VerificationFailed)
            {
                // Resolve THE specific match that was just decided
                var specificMatch = await _matchRepository.AsQueryable()
                    .FirstOrDefaultAsync(m => (m.LostItemId == entity.LostItemId && m.FoundItemId == entity.FoundItemId));
                
                if (specificMatch != null)
                {
                    specificMatch.IsMatchResolved = true;
                    await _matchRepository.UpdateAsync(specificMatch);
                }

                // If approved, move items to Handover status AND resolve ALL OTHER matches
                if (dto.Status == ClaimStatus.VerificationSucceeded)
                {
                    var otherMatches = await _matchRepository.AsQueryable()
                        .Where(m => (m.FoundItemId == entity.FoundItemId || m.LostItemId == entity.FoundItemId) && !m.IsMatchResolved)
                        .ToListAsync();
                    
                    foreach (var m in otherMatches)
                    {
                        m.IsMatchResolved = true;
                        await _matchRepository.UpdateAsync(m);
                    }

                    // PERFECTION: Automatically reject all OTHER pending claims for this Found item
                    var otherClaims = await _claimRepository.AsQueryable()
                        .Where(c => c.FoundItemId == entity.FoundItemId && c.Id != entity.Id && c.Status == ClaimStatus.VerificationPending)
                        .ToListAsync();

                    foreach (var otherClaim in otherClaims)
                    {
                        otherClaim.Status = ClaimStatus.VerificationFailed;
                        otherClaim.RejectionReason = "Item has been successfully reclaimed by another verified owner.";
                        await _claimRepository.UpdateAsync(otherClaim);
                    }

                    var foundItem = await _itemRepository.GetByIdAsync(entity.FoundItemId);
                    var lostItem = await _itemRepository.GetByIdAsync(entity.LostItemId);

                    if (foundItem == null || foundItem.Status == ItemStatus.Handover)
                    {
                        return Response<GetClaimDto>.SetCustomErrorResponse("This item has already been handed over or is unavailable.", StatusCodes.Status400BadRequest);
                    }

                    // Removed premature status updates. 
                    // Item status should only change to Handover during the actual physical release process.
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

            // IDOR Protection: Students only see their own claim records (Admins see all)
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
