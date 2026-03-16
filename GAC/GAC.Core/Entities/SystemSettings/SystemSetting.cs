using System.ComponentModel.DataAnnotations;

namespace GAC.Core.Entities.SystemSettings
{
    public class SystemSetting : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string SettingKey { get; set; }

        [Required]
        [StringLength(500)]
        public string SettingValue { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}
