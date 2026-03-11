using System.ComponentModel.DataAnnotations;

namespace GAC.Core.Entities.ItemTypes
{
    public class MobileCompany : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public ICollection<MobileModel> Models { get; set; } = new List<MobileModel>();
    }
}
