namespace GAC.Application.Services.Identity.Dtos.Role
{
    public class AssignRoleToUserDto
    {
        public int UserId { get; set; }
        public List<string> RoleNames { get; set; } = new();
    }
}
