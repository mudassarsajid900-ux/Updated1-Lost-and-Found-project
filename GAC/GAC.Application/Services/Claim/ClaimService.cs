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
        private readonly IMapper _mapper;
        private readonly UserData _userData;

        public ClaimService(
            IGenericRepository<ClaimRequest> claimRepository,
            IMapper mapper,
            UserData userData)
        {
            _claimRepository = claimRepository;
            _mapper = mapper;
            _userData = userData;
        }

        public async Task<Response<GetClaimDto>> SubmitClaimAsync(CreateClaimDto dto)
        {
            var entity = new ClaimRequest
            {
                LostItemId = dto.LostItemId,
                FoundItemId = dto.FoundItemId,
                Status = ClaimStatus.VerificationPending,
                Score = 0 // Needs matching algorithm implementation
            };

            await _claimRepository.AddAsync(entity);

            var result = _mapper.Map<GetClaimDto>(entity);
            return Response<GetClaimDto>.SetSuccessResponse(result, "Claim submitted successfully", StatusCodes.Status201Created);
        }

        public async Task<Response<GetClaimDto>> UpdateClaimStatusAsync(UpdateClaimStatusDto dto)
        {
            var entity = await _claimRepository.GetByIdAsync((int)dto.ClaimId);
            if (entity == null)
                return Response<GetClaimDto>.NotFoundResponse();

            entity.Status = dto.Status;
            await _claimRepository.UpdateAsync(entity);

            var result = _mapper.Map<GetClaimDto>(entity);
            return Response<GetClaimDto>.SetSuccessResponse(result, "Claim status updated successfully");
        }

        public async Task<Response<GetClaimDto>> GetByIdAsync(long id)
        {
            var entity = await _claimRepository.GetByIdAsync((int)id);
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
