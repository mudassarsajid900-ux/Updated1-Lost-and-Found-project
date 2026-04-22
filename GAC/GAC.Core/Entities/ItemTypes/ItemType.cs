using System.ComponentModel.DataAnnotations;

namespace GAC.Core.Entities.ItemTypes
{
    public class ItemType : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Fields> Fields { get; set; }
    }
}
