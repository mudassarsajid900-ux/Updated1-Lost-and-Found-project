using AutoMapper;
using GAC.Application.Helper;
using GAC.Application.Interfaces.Replacement;
using GAC.Application.Interfaces.Shared;
using GAC.Application.Services.Replacement.Dtos;
using GAC.Common.Responce;
using GAC.Core.Entities.Replacment;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace GAC.Application.Services.Replacement
{
    public class ReplacementService : IReplacementService
    {
        private readonly IGenericRepository<ReplacmentRecord> _replacementRepository;
        private readonly IMapper _mapper;
        private readonly UserData _userData;

        public ReplacementService(
            IGenericRepository<ReplacmentRecord> replacementRepository,
            IMapper mapper,
            UserData userData)
        {
            _replacementRepository = replacementRepository;
            _mapper = mapper;
            _userData = userData;
        }

        public async Task<Response<GetReplacementDto>> CreateReplacementAsync(CreateReplacementDto dto)
        {
            var entity = new ReplacmentRecord
            {
                LostItemId = dto.ItemId,
            };

            await _replacementRepository.AddAsync(entity);

            var result = _mapper.Map<GetReplacementDto>(entity);
            return Response<GetReplacementDto>.SetSuccessResponse(result, "Replacement record created successfully", StatusCodes.Status201Created);
        }

        public async Task<Response<GetReplacementDto>> GetByIdAsync(long id)
        {
            var entity = await _replacementRepository.GetByIdAsync((int)id);
            if (entity == null)
                return Response<GetReplacementDto>.NotFoundResponse();

            var result = _mapper.Map<GetReplacementDto>(entity);
            return Response<GetReplacementDto>.SetSuccessResponse(result);
        }

        public async Task<Response<List<GetReplacementDto>>> GetMyReplacementsAsync()
        {
            var records = await _replacementRepository.AsQueryable()
                .Where(x => x.CreatedBy == _userData.UserId)
                .ToListAsync();

            var result = _mapper.Map<List<GetReplacementDto>>(records);
            return Response<List<GetReplacementDto>>.SetSuccessResponse(result);
        }
    }
}
