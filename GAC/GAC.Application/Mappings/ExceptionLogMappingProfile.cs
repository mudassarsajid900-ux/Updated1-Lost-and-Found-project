using AutoMapper;
using GAC.Application.Services.Identity.Dtos.Shared;
using GAC.Application.Services.Logs.Dtos;
using GAC.Core.Entities.ExceptionLogs;

namespace GAC.Application.Mappings
{
    public class ExceptionLogMappingProfile : Profile
    {
        public ExceptionLogMappingProfile()
        {
            CreateMap<ExceptionLogs, CreateExceptionLogDto>()
                .ForMember(dest => dest.Exception, opt => opt.NullSubstitute("-"))
                .ReverseMap();

            CreateMap<ExceptionLogs, CreateExceptionLogListDto>()
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt.ToString("dd MMM yyyy hh:mm tt")))
                .ReverseMap();
            CreateMap<ExceptionLogs, ExceptionLogListingDto>()
              .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt.ToString("dd MMM yyyy hh:mm tt")))
              .ReverseMap();
        }
    }
}
