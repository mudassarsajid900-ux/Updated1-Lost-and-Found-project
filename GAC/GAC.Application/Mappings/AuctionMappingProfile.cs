using AutoMapper;
using GAC.Application.Services.Auction.Dtos;
using GAC.Core.Entities.Auction;

namespace GAC.Application.Mappings
{
    public class AuctionMappingProfile : Profile
    {
        public AuctionMappingProfile()
        {
            CreateMap<AuctionRecord, GetAuctionDto>()
                .ForMember(dest => dest.ItemTitle, opt => opt.MapFrom(src => src.FoundItem.ItemType.Name))
                .ForMember(dest => dest.ItemImageUrl, opt => opt.MapFrom(src => src.FoundItem.ImageUrl));
            CreateMap<CreateAuctionDto, AuctionRecord>();
            CreateMap<Bid, GetBidDto>()
                .ForMember(dest => dest.BidderName, opt => opt.MapFrom(src => src.Bidder.FirstName + " " + src.Bidder.LastName));
        }
    }
}
