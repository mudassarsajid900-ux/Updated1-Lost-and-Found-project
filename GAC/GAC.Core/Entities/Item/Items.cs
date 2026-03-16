using GAC.Core.Entities.ItemTypes;
using GAC.Core.Entities.Locations;
using GAC.Core.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAC.Core.Entities.Item
{
    public class Items : BaseEntity
    {
        public DateTime EventTime { get; set; }

        public long LocationId { get; set; }
        [ForeignKey("LocationId")] public Location Location { get; set; }

        public long ItemTypeId { get; set; }
        [ForeignKey("ItemTypeId")] public ItemType ItemType { get; set; }

        public ICollection<ItemAttribute> Attributes { get; set; }
        public ItemStatus Status { get; set; }
        public ItemCondition Condition { get; set; }
        public ReportType ReportType { get; set; }
        public string? ImageUrl { get; set; }
    }
}
