using GAC.Core.Entities.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAC.Core.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required] public int CreatedBy { get; set; }
        [Required] public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public int? LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedOn { get; set; } 
        public int? DeletedBy { get; set; }

        [ForeignKey("CreatedBy")] public ApplicationUser CreatedByUser { get; set; }
        [ForeignKey("LastModifiedBy")] public ApplicationUser ModifiedByUser { get; set; }
        [ForeignKey("DeletedBy")] public ApplicationUser DeletedByUser { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
