
using Microsoft.AspNetCore.Identity;

namespace GAC.Core.Entities.Identity;

public class ApplicationRole : IdentityRole<int>
{
    public string? Description { get; set; }

    //public virtual ICollection<RoleMenu> RoleMenus { get; set; }
}