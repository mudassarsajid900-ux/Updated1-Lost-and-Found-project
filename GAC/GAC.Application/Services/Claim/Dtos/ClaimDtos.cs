using GAC.Core.Enums;

namespace GAC.Application.Services.ClaimRequests.Dtos
{
    public class ClaimRequestDto
    {
        public long LostItemId { get; set; }
        public long FoundItemId { get; set; }
        public long Score { get; set; }
        public ClaimStatus Status { get; set; }
        public string? RejectionReason { get; set; }
    }

    public class CreateClaimDto
    {
        public long LostItemId { get; set; }
        public long FoundItemId { get; set; }
        public string? Description { get; set; }
    }

    public class UpdateClaimStatusDto
    {
        public long ClaimId { get; set; }
        public ClaimStatus Status { get; set; }
        public string? RejectionReason { get; set; }
    }

    public class GetClaimDto : ClaimRequestDto
    {
        public long Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? ClaimDescription { get; set; }
    }
}
