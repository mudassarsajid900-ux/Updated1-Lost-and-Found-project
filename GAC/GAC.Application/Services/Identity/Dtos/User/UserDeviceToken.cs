using GAC.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace GAC.Application.Services.Identity.Dtos.User
{
    public class UserDeviceToken : BaseEntity
    {
        [StringLength(2500)]
        [Required]
        public string DeviceToken { get; set; }
        [StringLength(500)]
        public string? DeviceInfo { get; set; }
        [StringLength(30)]
        public string? DeviceType { get; set; }
        [StringLength(200)]
        public string UserTimeZone { get; set; }
        public int UserId { get; set; }
        [StringLength(200)]
        public string? UserName { get; set; }

    }
}
