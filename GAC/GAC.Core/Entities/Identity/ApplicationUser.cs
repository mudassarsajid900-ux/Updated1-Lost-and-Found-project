using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GAC.Core.Entities.Identity
{
    public class ApplicationUser : IdentityUser<int>
    {

        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        [StringLength(100)]
        public string? PhoneNumber { get; set; }
        [StringLength(500)]
        public string? ProfileImage { get; set; }
        public bool IsActive { get; set; }
        public string RefreshToken { get; set; } = string.Empty;  
        public DateTime RefreshTokenExpiryTime { get; set; } = DateTime.UtcNow.AddYears(-1);
    }
}

