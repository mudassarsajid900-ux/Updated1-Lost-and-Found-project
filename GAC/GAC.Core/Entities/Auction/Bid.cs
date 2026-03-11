using GAC.Core.Entities.Identity;
using GAC.Core.Entities.Item;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAC.Core.Entities.Auction
{
    public class Bid : BaseEntity
    {
        public long FoundItemId { get; set; }
        [ForeignKey("FoundItemId")] public Items FoundItem { get; set; }
        public int BidderId { get; set; }
        [ForeignKey("BidderId")] public ApplicationUser Bidder { get; set; }
        public long BidAmount { get; set; }
    }
}
