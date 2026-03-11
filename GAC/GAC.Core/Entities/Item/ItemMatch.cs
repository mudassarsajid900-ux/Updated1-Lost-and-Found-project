using GAC.Core.Entities.Identity;
using GAC.Core.Entities.Item;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAC.Core.Entities.Item
{
    public class ItemMatch : BaseEntity
    {
        public long LostItemId { get; set; }
        [ForeignKey("LostItemId")] public Items LostItem { get; set; }

        public long FoundItemId { get; set; }
        [ForeignKey("FoundItemId")] public Items FoundItem { get; set; }

        public double MatchConfidenceScore { get; set; }
        public bool IsMatchResolved { get; set; } = false;

        public int UserId { get; set; }
        [ForeignKey("UserId")] public ApplicationUser User { get; set; }
    }
}
