using GAC.Application.Services.Item.Dtos;
using GAC.Core.Enums;

namespace GAC.Application.Services.Auction.Dtos
{
    public class AuctionRecordDto
    {
        public long FoundItemId { get; set; }
        public long HighestBid { get; set; }
        public string HighestBidderId { get; set; }
        public string CnicImagePath { get; set; }
        public string PersonImagePath { get; set; }
    }

    public class CreateAuctionDto
    {
        public long FoundItemId { get; set; }
        public long StartingPrice { get; set; }
        public int DurationHours { get; set; }
    }

    public class PlaceBidDto
    {
        public long AuctionId { get; set; }
        public long BidAmount { get; set; }
    }

    public class GetAuctionDto : AuctionRecordDto
    {
        public long Id { get; set; }
        public bool IsActive { get; set; }
        public string ItemTitle { get; set; }
        public string ItemImageUrl { get; set; }
        public DateTime EndDate { get; set; }
        public string HighestBidderName { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<GetItemAttributes> Attributes { get; set; } = new();
    }

    public class GetBidDto
    {
        public long Id { get; set; }
        public string BidderName { get; set; }
        public long BidAmount { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    public class MyBidDto
    {
        public long AuctionId { get; set; }
        public string ItemTitle { get; set; }
        public string ItemImageUrl { get; set; }
        public long MyHighestBid { get; set; }
        public long CurrentHighestBid { get; set; }
        public bool IsHighestBidder { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class MyWinDto
    {
        public long AuctionId { get; set; }
        public string ItemTitle { get; set; }
        public string ItemImageUrl { get; set; }
        public long WinningBid { get; set; }
        public DateTime EndDate { get; set; }
        public string OrderNumber { get; set; }
    }
}
