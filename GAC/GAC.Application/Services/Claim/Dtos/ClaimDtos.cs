using GAC.Core.Enums;

namespace GAC.Application.Services.ClaimRequests.Dtos
{
    public class ClaimRequestDto
    {
        public long LostItemId { get; set; }
        public long FoundItemId { get; set; }
        public long Score { get; set; }
        public ClaimStatus Status { get; set; }
    }

    public class CreateClaimDto
    {
        public long LostItemId { get; set; }
        public long FoundItemId { get; set; }
    }

    public class UpdateClaimStatusDto
    {
        public long ClaimId { get; set; }
        public ClaimStatus Status { get; set; }
    }

    public class GetClaimDto : ClaimRequestDto
    {
        public long Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
