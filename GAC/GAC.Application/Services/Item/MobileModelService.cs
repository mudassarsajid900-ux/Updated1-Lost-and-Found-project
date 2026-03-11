using AutoMapper;
using GAC.Application.Interfaces.Item;
using GAC.Application.Interfaces.Shared;
using GAC.Application.Services.Item.Dtos;
using GAC.Common.Responce;
using GAC.Core.Entities.ItemTypes;
using Microsoft.EntityFrameworkCore;

namespace GAC.Application.Services.Item
{
    public class MobileModelService : IMobileModelService
    {
        private readonly IGenericRepository<MobileCompany> _companyRepository;
        private readonly IGenericRepository<MobileModel> _modelRepository;
        private readonly IMapper _mapper;

        public MobileModelService(
            IGenericRepository<MobileCompany> companyRepository,
            IGenericRepository<MobileModel> modelRepository,
            IMapper mapper)
        {
            _companyRepository = companyRepository;
            _modelRepository = modelRepository;
            _mapper = mapper;
        }

        public async Task<Response<List<MobileCompanyDto>>> GetCompaniesAsync()
        {
            var companies = await _companyRepository.AsNoTracking().OrderBy(c => c.Name).ToListAsync();
            var dtoList = _mapper.Map<List<MobileCompanyDto>>(companies);
            return Response<List<MobileCompanyDto>>.SetSuccessResponse(dtoList);
        }

        public async Task<Response<List<MobileModelDto>>> GetModelsByCompanyAsync(long companyId)
        {
            var models = await _modelRepository.AsNoTracking()
                .Where(m => m.MobileCompanyId == companyId)
                .OrderBy(m => m.Name)
                .ToListAsync();
                
            var dtoList = _mapper.Map<List<MobileModelDto>>(models);
            return Response<List<MobileModelDto>>.SetSuccessResponse(dtoList);
        }
    }
}
