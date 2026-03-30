using AutoMapper;
using GAC.Application.Services.Replacement.Dtos;
using GAC.Core.Entities.Replacement;

namespace GAC.Application.Mappings
{
    public class ReplacementMappingProfile : Profile
    {
        public ReplacementMappingProfile()
        {
            CreateMap<ReplacementRecord, GetReplacementDto>()
                .ForMember(d => d.LostItemTitle, o => o.MapFrom(s => s.LostItem.ItemType.Name))
                .ForMember(d => d.FoundItemTitle, o => o.MapFrom(s => s.FoundItem != null ? s.FoundItem.ItemType.Name : "Not Assigned"))
                .ForMember(d => d.ReporterName, o => o.MapFrom(s => s.LostItem.CreatedByUser != null ? (s.LostItem.CreatedByUser.FirstName + " " + s.LostItem.CreatedByUser.LastName).Trim() : "Unknown Student"));
            
            CreateMap<CreateReplacementDto, ReplacementRecord>();
        }
    }
}
