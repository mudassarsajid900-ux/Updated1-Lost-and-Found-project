using GAC.Core.Enums;
using Microsoft.AspNetCore.Http;

namespace GAC.Application.Services.Handover.Dtos
{
    public class CreateHandoverDto
    {
        public long ItemId { get; set; }
        public long? ClaimRequestId { get; set; }
        public long? ReplacementRecordId { get; set; }
        public long? AuctionRecordId { get; set; }
        
        public HandoverType HandoverType { get; set; }
        public string ReceiverName { get; set; } = string.Empty;
        public string ReceiverCnic { get; set; } = string.Empty;
        public string ReceiverPhone { get; set; } = string.Empty;
        public string AdminNotes { get; set; } = string.Empty;
        
        public IFormFile? CnicPhoto { get; set; }
        public IFormFile? PersonPhoto { get; set; }
    }

    public class GetHandoverDto
    {
        public long Id { get; set; }
        public long ItemId { get; set; }
        public string ItemTitle { get; set; } = string.Empty;
        public string ItemDescription { get; set; } = string.Empty;
        public string ItemCategory { get; set; } = string.Empty;
        public string ReceiverName { get; set; } = string.Empty;
        public string ReceiverCnic { get; set; } = string.Empty;
        public string ReceiverPhone { get; set; } = string.Empty;
        public string? CnicImagePath { get; set; }
        public string? PersonImagePath { get; set; }
        public string AdminNotes { get; set; } = string.Empty;
        public HandoverType HandoverType { get; set; }
        public string HandoverTypeName => HandoverType.ToString();
        public List<GAC.Application.Services.Item.Dtos.GetItemAttributes> Attributes { get; set; } = new();
        public DateTime CreatedOn { get; set; }
    }

    public class PendingHandoverDto
    {
        public long ItemId { get; set; }
        public string ItemTitle { get; set; } = string.Empty;
        public string? ItemImageUrl { get; set; }
        public HandoverType HandoverType { get; set; }
        public string HandoverTypeName => HandoverType.ToString();
        
        // References to original records
        public long? ClaimRequestId { get; set; }
        public long? ReplacementRecordId { get; set; }
        public long? AuctionRecordId { get; set; }
        
        // Person details
        public string TargetPersonName { get; set; } = string.Empty;
        public string TargetPersonEmail { get; set; } = string.Empty;
        public string TargetPersonPhone { get; set; } = string.Empty;
        public string ItemDescription { get; set; } = string.Empty;
        public string ItemLocation { get; set; } = string.Empty;
        public List<GAC.Application.Services.Item.Dtos.GetItemAttributes> Attributes { get; set; } = new();
    }
}
