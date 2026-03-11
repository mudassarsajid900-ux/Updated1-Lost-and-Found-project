using GAC.Application.Interfaces.Identity;
using GAC.Application.Interfaces.Shared;
using GAC.Application.Services.Identity.Dtos.Role;
using GAC.Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace GAC.Application.Services.Identity
{
    public class RolesService : IRolesService
    {
        private readonly IGenericRepository<ApplicationRole> _roleRepo;
        private readonly IGenericRepository<ApplicationUser> _userRepo;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public RolesService(
            IGenericRepository<ApplicationRole> roleRepo,
            IGenericRepository<ApplicationUser> userRepo,
            RoleManager<ApplicationRole> roleManager,
            UserManager<ApplicationUser> userManager)
        {
            _roleRepo = roleRepo;
            _userRepo = userRepo;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<IEnumerable<RoleDto>> GetAllRolesAsync()
        {
            var roles = await _roleRepo.GetAllAsync(asNoTracking: true);
            var result = new List<RoleDto>();

            foreach (var role in roles)
            {
               

                result.Add(new RoleDto
                {
                    Id = role.Id,
                    Name = role.Name ?? string.Empty,
                });
            }

            return result;
        }

        public async Task<RoleDto> GetRoleByIdAsync(int roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId.ToString());
            if (role == null) throw new KeyNotFoundException("Role not found");


            return new RoleDto
            {
                Id = role.Id,
                Name = role.Name ?? string.Empty,
               
            };
        }

        public async Task<RoleDto> CreateRoleAsync(CreateRoleDto dto)
        {
            if (dto == null) throw new ArgumentNullException(nameof(dto));

            // Check if role already exists
            var roleExists = await _roleManager.RoleExistsAsync(dto.Name);
            if (roleExists)
                throw new InvalidOperationException($"Role '{dto.Name}' already exists.");

            // Create the new role
            var role = new ApplicationRole { Name = dto.Name };
            var result = await _roleManager.CreateAsync(role);
            if (!result.Succeeded)
                throw new InvalidOperationException(string.Join(", ", result.Errors.Select(e => e.Description)));
            return await GetRoleByIdAsync(role.Id);
        }

        public async Task<RoleDto> UpdateRoleAsync(int roleId, UpdateRoleDto dto)
        {
            if (dto == null) throw new ArgumentNullException(nameof(dto));

            var role = await _roleRepo.GetByIdAsync(roleId);
            if (role == null) throw new KeyNotFoundException("Role not found");

            role.Name = dto.Name;
            await _roleManager.UpdateAsync(role);

            return await GetRoleByIdAsync(role.Id);
        }

        public async Task DeleteRoleAsync(int roleId)
        {
            var role = await _roleRepo.GetByIdAsync(roleId);
            if (role == null) throw new KeyNotFoundException("Role not found");

            await _roleManager.DeleteAsync(role);
        }

        public async Task AssignRolesToUserAsync(int userId, List<string> roleNames)
        {
            var user = await _userRepo.GetByIdAsync(userId);
            if (user == null) throw new KeyNotFoundException("User not found");

            foreach (var roleName in roleNames)
            {
                var roleExists = await _roleManager.RoleExistsAsync(roleName);
                if (!roleExists) throw new KeyNotFoundException($"Role '{roleName}' does not exist");

                var result = await _userManager.AddToRoleAsync(user, roleName);
                if (!result.Succeeded)
                    throw new InvalidOperationException(string.Join(", ", result.Errors.Select(e => e.Description)));
            }
        }
    }
}
