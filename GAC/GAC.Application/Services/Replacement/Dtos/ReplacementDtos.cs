using GAC.Core.Enums;

namespace GAC.Application.Services.Replacement.Dtos
{
    public class CreateReplacementDto
    {
        public long LostItemId { get; set; }
        public string RequestReason { get; set; }
        public string DesiredSpecifications { get; set; }
    }

    public class GetReplacementDto
    {
        public long Id { get; set; }
        public long LostItemId { get; set; }
        public string LostItemTitle { get; set; }
        public long? FoundItemId { get; set; }
        public string FoundItemTitle { get; set; }
        public string RequestReason { get; set; }
        public string DesiredSpecifications { get; set; }
        public ReplacementStatus Status { get; set; }
        public string StatusName => Status.ToString();
        public string AdminNotes { get; set; }
        public DateTime? DecisionDate { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class AdminProcessReplacementDto
    {
        public long RequestId { get; set; }
        public long FoundItemId { get; set; }
        public string AdminNotes { get; set; }
        public bool IsApproved { get; set; }
    }

    public class ReplacementEligibleItemDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime ReportedDate { get; set; }
        public int DaysSinceReported { get; set; }
        public bool IsEligible { get; set; }
    }
}
