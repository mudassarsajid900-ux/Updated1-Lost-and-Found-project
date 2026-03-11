
using GAC.Core.Entities.Identity;
using GAC.Core.Entities.Item;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAC.Core.Entities.Auction
{
    public class AuctionRecord : BaseEntity
    {
        public long FoundItemId { get; set; }
        [ForeignKey("FoundItemId")] public Items FoundItem { get; set; }
        public long HighestBid { get; set; }
        public int HighestBidderId { get; set; }
        [ForeignKey("HighestBidderId")] public ApplicationUser HighestBidder { get; set; }
        public string CnicImagePath { get; set; }
        public string PersonImagePath { get; set; }
    }
}
