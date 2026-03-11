using GAC.Core.Entities.Item;
using System.ComponentModel.DataAnnotations;

namespace GAC.Core.Entities.ItemTypes
{
    public class ItemAttribute : BaseEntity
    {
        public long LostItemId { get; set; }
        public Items LostItem { get; set; }

        [StringLength(100)]
        public string FieldName { get; set; }

        [StringLength(100)]
        public string FieldValue { get; set; }
    }
}
