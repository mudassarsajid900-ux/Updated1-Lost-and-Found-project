using Microsoft.AspNetCore.Identity;

namespace GAC.Core.Entities.Identity
{
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public DateTime? PermissionFrom { get; set; }
        public DateTime? PermissionTo { get; set; }
    }
}
