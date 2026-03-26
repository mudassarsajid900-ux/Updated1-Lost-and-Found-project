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
                    opt => opt.MapFrom(src => src.Attributes))
                .ForMember(dest => dest.ReporterName, 
                    opt => opt.MapFrom(src => src.CreatedByUser != null 
                        ? (src.CreatedByUser.FirstName + " " + src.CreatedByUser.LastName)
                        : "Campus System"))
                .ForMember(dest => dest.ReporterEmail, 
                    opt => opt.MapFrom(src => src.CreatedByUser != null ? src.CreatedByUser.Email : "n/a"))
                .ForMember(dest => dest.ReporterPhone, 
                    opt => opt.MapFrom(src => src.CreatedByUser != null ? src.CreatedByUser.PhoneNumber : "n/a"))
                .ForMember(dest => dest.CreatedOn, 
                    opt => opt.MapFrom(src => src.CreatedOn))
                .ForMember(dest => dest.IsVerifiedByAdmin, 
                    opt => opt.MapFrom(src => src.IsVerifiedByAdmin));

            CreateMap<ItemAttribute, GetItemAttributes>();
            CreateMap<ItemType, GetItemTypeDto>();
            CreateMap<MobileCompany, MobileCompanyDto>();
            CreateMap<MobileModel, MobileModelDto>();
        }
    }


}
