using AutoMapper;
using GAC.Application.Services.Identity.Dtos.Auth;
using GAC.Core.Entities.Identity;

namespace GAC.Application.Mappings
{
    public class AuthServiceMappingProfile : Profile
    {
        public AuthServiceMappingProfile()
        {

            CreateMap<RegisterDto, ApplicationUser>().ReverseMap();
        }
    }
}
