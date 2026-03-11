using GAC.Application.Services.Identity.Dtos.Role;

namespace GAC.Application.Interfaces.Identity
{
    public interface IRolesService
    {
        Task<IEnumerable<RoleDto>> GetAllRolesAsync();
        Task<RoleDto> GetRoleByIdAsync(int roleId);
        Task<RoleDto> CreateRoleAsync(CreateRoleDto dto);
        Task<RoleDto> UpdateRoleAsync(int roleId, UpdateRoleDto dto);
        Task DeleteRoleAsync(int roleId);
        Task AssignRolesToUserAsync(int userId, List<string> roleNames);
    }
}
