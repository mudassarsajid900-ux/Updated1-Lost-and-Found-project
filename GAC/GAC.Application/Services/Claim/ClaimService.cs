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

namespace GAC.Application.Services.ClaimRequests
{
    public class ClaimService : IClaimService
    {
        private readonly IGenericRepository<ClaimRequest> _claimRepository;
        private readonly IGenericRepository<GAC.Core.Entities.Item.Items> _itemRepository;
        private readonly IMapper _mapper;
        private readonly UserData _userData;

        public ClaimService(
            IGenericRepository<ClaimRequest> claimRepository,
            IGenericRepository<GAC.Core.Entities.Item.Items> itemRepository,
            IMapper mapper,
            UserData userData)
        {
            _claimRepository = claimRepository;
            _itemRepository = itemRepository;
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
            await _claimRepository.UpdateAsync(entity);

            var result = _mapper.Map<GetClaimDto>(entity);
            return Response<GetClaimDto>.SetSuccessResponse(result, "Claim status updated successfully");
        }

        public async Task<Response<GetClaimDto>> GetByIdAsync(long id)
        {
            var entity = await _claimRepository.GetByIdAsync(id);
            if (entity == null)
                return Response<GetClaimDto>.NotFoundResponse();

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
