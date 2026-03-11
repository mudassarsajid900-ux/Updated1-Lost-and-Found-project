using GAC.Core.Entities.Item;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAC.Core.Entities.Replacment
{
    public class ReplacmentRecord : BaseEntity
    {
        public long FoundItemId { get; set; }
        [ForeignKey("FoundItemId")] public Items FoundItem { get; set; }
        public long LostItemId { get; set; }
        [ForeignKey("LostItemId")] public Items LostItem { get; set; }

        [StringLength(150)]
        public string CnicImagePath { get; set; }
        [StringLength(150)]
        public string PersonImagePath { get; set; }
    }
}
