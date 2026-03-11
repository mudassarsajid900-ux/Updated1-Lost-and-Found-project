using AutoMapper;
using GAC.Application.Services.ClaimRequests.Dtos;
using GAC.Core.Entities.Claims;

namespace GAC.Application.Mappings
{
    public class ClaimMappingProfile : Profile
    {
        public ClaimMappingProfile()
        {
            CreateMap<ClaimRequest, GetClaimDto>();
            CreateMap<CreateClaimDto, ClaimRequest>();
        }
    }
}
