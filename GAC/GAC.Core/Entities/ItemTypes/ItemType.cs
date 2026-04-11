using System.ComponentModel.DataAnnotations;

namespace GAC.Core.Entities.ItemTypes
{
    public class ItemType : BaseEntity
    {
        [StringLength(50)]
        public string Name { get; set; }

        public ICollection<Fields> Fields { get; set; }
    }
}
