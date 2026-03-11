using GAC.Core.Entities.Item;
using GAC.Core.Enums;

namespace GAC.Core.Entities.Claims
{
    public class ClaimRequest:BaseEntity
    {
        public long LostItemId { get; set; }
        public Items LostItem { get; set; }
        public long FoundItemId { get; set; }
        public Items FoundItem { get; set; }  
        public long Score { get; set; }
        public ClaimStatus Status { get; set; }
    }
}
