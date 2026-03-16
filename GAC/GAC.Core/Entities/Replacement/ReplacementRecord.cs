using GAC.Core.Entities.Item;
using GAC.Core.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAC.Core.Entities.Replacement
{
    public class ReplacementRecord : BaseEntity
    {
        public long LostItemId { get; set; }
        [ForeignKey("LostItemId")] 
        public Items LostItem { get; set; }

        public long? FoundItemId { get; set; }
        [ForeignKey("FoundItemId")] 
        public Items FoundItem { get; set; }

        [StringLength(500)]
        public string RequestReason { get; set; }

        [StringLength(1000)]
        public string DesiredSpecifications { get; set; }

        public ReplacementStatus Status { get; set; } = ReplacementStatus.Pending;

        [StringLength(1000)]
        public string AdminNotes { get; set; }

        public DateTime? DecisionDate { get; set; }

        [StringLength(150)]
        public string CnicImagePath { get; set; }

        [StringLength(150)]
        public string PersonImagePath { get; set; }
    }
}
