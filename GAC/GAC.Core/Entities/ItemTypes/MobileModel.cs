using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAC.Core.Entities.ItemTypes
{
    public class MobileModel : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public long MobileCompanyId { get; set; }

        [ForeignKey("MobileCompanyId")]
        public MobileCompany MobileCompany { get; set; }
    }
}
