using AutoMapper;
using GAC.Application.Services.Item.Dtos;
using GAC.Core.Entities.Item;
using GAC.Core.Entities.ItemTypes;

namespace GAC.Application.Mappings
{
    public class ItemMappingProfile : Profile
    {
        public ItemMappingProfile()
        {
            // Create
            CreateMap<CreateItemDto, Items>()
                .ForMember(dest => dest.Attributes,
                    opt => opt.MapFrom(src => src.Attributes));

            CreateMap<CreateItemAttributeDto, ItemAttribute>();

            // Update
            CreateMap<UpdateItemDto, Items>()
                .ForMember(dest => dest.Attributes, opt => opt.Ignore());

            CreateMap<UpdateItemAttributeDto, ItemAttribute>();

            // Get
            CreateMap<Items, GetItemDto>()
                .ForMember(dest => dest.LocationName,
                    opt => opt.MapFrom(src => src.Location.Name))
                .ForMember(dest => dest.Type,
                    opt => opt.MapFrom(src => src.ItemType.Name))
                .ForMember(dest => dest.Attributes,
                    opt => opt.MapFrom(src => src.Attributes));

            CreateMap<ItemAttribute, GetItemAttributes>();
            CreateMap<ItemType, GetItemTypeDto>();
            CreateMap<MobileCompany, MobileCompanyDto>();
            CreateMap<MobileModel, MobileModelDto>();
        }
    }


}
