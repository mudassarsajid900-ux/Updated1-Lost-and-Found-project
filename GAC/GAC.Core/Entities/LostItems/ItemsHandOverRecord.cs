using GAC.Core.Entities.Claims;
using GAC.Core.Entities.Replacement;
using GAC.Core.Entities.Auction;
using GAC.Core.Entities.Item;
using GAC.Core.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAC.Core.Entities.LostItems
{
    public class ItemsHandOverRecord : BaseEntity
    {
        public long ItemId { get; set; }
        [ForeignKey("ItemId")] 
        public Items Item { get; set; }

        public long? ClaimRequestId { get; set; }
        [ForeignKey("ClaimRequestId")] 
        public ClaimRequest ClaimRequest { get; set; }

        public long? ReplacementRecordId { get; set; }
        [ForeignKey("ReplacementRecordId")] 
        public ReplacementRecord ReplacementRecord { get; set; }

        public long? AuctionRecordId { get; set; }
        [ForeignKey("AuctionRecordId")] 
        public AuctionRecord AuctionRecord { get; set; }

        public string CnicImagePath { get; set; }
        public string PersonImagePath { get; set; }
        
        public HandoverType HandoverType { get; set; }
        
        public string ReceiverName { get; set; }
        public string ReceiverCnic { get; set; }
        public string ReceiverPhone { get; set; }
        
        public string AdminNotes { get; set; }
    }
}
