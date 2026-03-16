using AutoMapper;
using GAC.Application.Services.Handover.Dtos;
using GAC.Core.Entities.LostItems;

namespace GAC.Application.Mappings
{
    public class HandoverMappingProfile : Profile
    {
        public HandoverMappingProfile()
        {
            CreateMap<CreateHandoverDto, ItemsHandOverRecord>()
                .ForMember(dest => dest.CnicImagePath, opt => opt.Ignore())
                .ForMember(dest => dest.PersonImagePath, opt => opt.Ignore());

            CreateMap<ItemsHandOverRecord, GetHandoverDto>()
                .ForMember(dest => dest.ItemTitle, opt => opt.MapFrom(src => src.Item != null && src.Item.ItemType != null ? src.Item.ItemType.Name : "Unknown"));
        }
    }
}
