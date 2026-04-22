using GAC.Core.Entities.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAC.Core.Entities
{
    /// <summary>
    /// Base class for all domain entities. 
    /// Provides audit fields and supports soft-delete functionality.
    /// </summary>
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required] public int CreatedBy { get; set; }
        /// <summary>
        /// Audit timestamp for record creation (Stored in UTC).
        /// </summary>
        [Required] public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public int? LastModifiedBy { get; set; }
        /// <summary>
        /// Audit timestamp for last modification (Stored in UTC).
        /// </summary>
        public DateTime LastModifiedOn { get; set; } = DateTime.UtcNow;
        
        /// <summary>
        /// Global soft-delete flag. Query filters automatically exclude records where IsDeleted = true.
        /// </summary>
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedOn { get; set; } 
        public int? DeletedBy { get; set; }

        [ForeignKey("CreatedBy")] public ApplicationUser CreatedByUser { get; set; }
        [ForeignKey("LastModifiedBy")] public ApplicationUser ModifiedByUser { get; set; }
        [ForeignKey("DeletedBy")] public ApplicationUser DeletedByUser { get; set; }
        
        /// <summary>
        /// Indicates if the record is currently active in the system.
        /// </summary>
        public bool IsActive { get; set; } = true;
    }
}
