using AutoMapper;
using GAC.Application.Services.Replacement.Dtos;
using GAC.Core.Entities.Replacment;

namespace GAC.Application.Mappings
{
    public class ReplacementMappingProfile : Profile
    {
        public ReplacementMappingProfile()
        {
            CreateMap<ReplacmentRecord, GetReplacementDto>();
            CreateMap<CreateReplacementDto, ReplacmentRecord>();
        }
    }
}
