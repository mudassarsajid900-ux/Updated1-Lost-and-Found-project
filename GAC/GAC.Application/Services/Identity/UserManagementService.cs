using GAC.Application.Interfaces.Identity;
using GAC.Application.Interfaces.Shared;
using GAC.Application.Services.Identity.Dtos.User;
using GAC.Common.Pagination;
using GAC.Common.Responce;
using GAC.Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GAC.Application.Services.Identity
{
    public class UserManagementService : IUserManagementService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IGenericRepository<ApplicationUser> _userRepository;

        public UserManagementService(
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            IGenericRepository<ApplicationUser> userRepository)
        {
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _roleManager = roleManager ?? throw new ArgumentNullException(nameof(roleManager));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        public async Task<(IEnumerable<UserDto> Users, int TotalCount)> GetUsersAsync(DataTableRequest request)
        {
            int pageNumber = Math.Max(1, request.Start / request.Length + 1);
            Expression<Func<ApplicationUser, bool>> filter = user => user.IsActive;

            if (!string.IsNullOrWhiteSpace(request?.Search?.Value))
            {
                string searchQuery = request.Search.Value;
                filter = user =>
                    (user.UserName != null && user.UserName.Contains(searchQuery)) ||
                    (user.Email != null && user.Email.Contains(searchQuery)) ||
                    (user.FirstName != null && user.FirstName.Contains(searchQuery)) ||
                    (user.LastName != null && user.LastName.Contains(searchQuery));
            }

            string sortColumn = request.Columns[request.Order[0].Column].Data;
            bool sortDescending = string.Equals(request.Order[0].Dir, "desc", StringComparison.OrdinalIgnoreCase);

            (IEnumerable<ApplicationUser> userData, int totalCount) = await _userRepository.GetPagedAsync(
                pageNumber, request.Length, filter, sortColumn, sortDescending);

            var userDtos = new List<UserDto>();
            foreach (var user in userData)
            {
                var roles = await _userManager.GetRolesAsync(user);
                userDtos.Add(new UserDto
                {
                    Id = user.Id,
                    UserName = user.UserName ?? string.Empty,
                    Email = user.Email ?? string.Empty,
                    FirstNameEn = user.FirstName ?? string.Empty,
                    FirstNameAr = user.FirstName ?? string.Empty,
                    LastNameEn = user.LastName ?? string.Empty,
                    LastNameAr = user.LastName ?? string.Empty,
                    IsActive = user.IsActive,
                    Roles = roles.ToList()
                });
            }

            return (userDtos, totalCount);
        }

        public async Task<Response<UserDto>> GetUserByIdAsync(int userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null)
                return Response<UserDto>.UserNotFoundResponse();

            var roles = await _userManager.GetRolesAsync(user);
            var userDto = new UserDto
            {
                Id = user.Id,
                UserName = user.UserName ?? string.Empty,
                Email = user.Email ?? string.Empty,
                FirstNameEn = user.FirstName ?? string.Empty,
                FirstNameAr = user.FirstName ?? string.Empty,
                LastNameEn = user.LastName ?? string.Empty,
                LastNameAr = user.LastName ?? string.Empty,
                IsActive = user.IsActive,
                Roles = roles.ToList()
            };

            return Response<UserDto>.SetSuccessResponse(userDto);
        }

        public async Task<Response<bool>> UserExistsAsync(string emailOrUsername)
        {
            if (string.IsNullOrWhiteSpace(emailOrUsername))
                return Response<bool>.SetSuccessResponse(false);

            var userByEmail = await _userManager.FindByEmailAsync(emailOrUsername);
            if (userByEmail != null)
                return Response<bool>.SetSuccessResponse(true);

            var userByName = await _userManager.FindByNameAsync(emailOrUsername);
            if (userByName != null)
                return Response<bool>.SetSuccessResponse(true);

            return Response<bool>.SetSuccessResponse(false);
        }

        public async Task<Response<bool>> CreateUserAsync(CreateUserDto dto)
        {
            if (dto == null)
                return Response<bool>.SetCustomErrorResponse("Invalid payload.", 500);

            var existingUser = await _userManager.FindByEmailAsync(dto.Email);
            if (existingUser != null)
                return Response<bool>.SetCustomErrorResponse("Email already in use.", 500);

            var newUser = new ApplicationUser
            {
                Email = dto.Email,
                UserName = string.IsNullOrWhiteSpace(dto.UserName) ? dto.Email : dto.UserName,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                IsActive = true
            };

            var createResult = await _userManager.CreateAsync(newUser, dto.Password);
            if (!createResult.Succeeded)
                return Response<bool>.SetCustomErrorResponse(
                    string.Join(", ", createResult.Errors.Select(error => error.Description)), 500);

            if (dto.RoleId.HasValue)
            {
                var role = await _roleManager.FindByIdAsync(dto.RoleId.Value.ToString());
                if (role != null && role.Name != null)
                {
                    var addRoleResult = await _userManager.AddToRoleAsync(newUser, role.Name);
                    if (!addRoleResult.Succeeded)
                        return Response<bool>.SetCustomErrorResponse(
                            string.Join(", ", addRoleResult.Errors.Select(error => error.Description)), 500);
                }
            }

            return Response<bool>.SetSuccessResponse(true);
        }

        public async Task<Response<bool>> UpdateUserAsync(UpdateUserDto dto)
        {
            if (dto == null)
                return Response<bool>.SetCustomErrorResponse("Invalid payload.", 500);

            var existingUser = await _userManager.FindByIdAsync(dto.Id.ToString());
            if (existingUser == null)
                return Response<bool>.UserNotFoundResponse();

            existingUser.Email = dto.Email;
            existingUser.UserName = dto.UserName;
            existingUser.FirstName = dto.FirstName;
            existingUser.LastName = dto.LastName;

            var updateResult = await _userManager.UpdateAsync(existingUser);
            if (!updateResult.Succeeded)
                return Response<bool>.SetCustomErrorResponse(
                    string.Join(", ", updateResult.Errors.Select(error => error.Description)), 500);

            if (!string.IsNullOrWhiteSpace(dto.Password))
            {
                var passwordResetToken = await _userManager.GeneratePasswordResetTokenAsync(existingUser);
                var passwordResult = await _userManager.ResetPasswordAsync(existingUser, passwordResetToken, dto.Password);
                if (!passwordResult.Succeeded)
                    return Response<bool>.SetCustomErrorResponse(
                        string.Join(", ", passwordResult.Errors.Select(error => error.Description)), 500);
            }

            if (dto.RoleId.HasValue)
            {
                var newRole = await _roleManager.FindByIdAsync(dto.RoleId.Value.ToString());
                if (newRole != null && newRole.Name != null)
                {
                    var currentRoles = await _userManager.GetRolesAsync(existingUser);
                    if (!currentRoles.Contains(newRole.Name))
                    {
                        if (currentRoles.Any())
                            await _userManager.RemoveFromRolesAsync(existingUser, currentRoles);

                        var addRoleResult = await _userManager.AddToRoleAsync(existingUser, newRole.Name);
                        if (!addRoleResult.Succeeded)
                            return Response<bool>.SetCustomErrorResponse(
                                string.Join(", ", addRoleResult.Errors.Select(error => error.Description)), 500);
                    }
                }
            }

            return Response<bool>.SetSuccessResponse(true);
        }

        public async Task<Response<bool>> DeleteUserAsync(int userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null)
                return Response<bool>.UserNotFoundResponse();

            var deleteResult = await _userManager.DeleteAsync(user);
            if (!deleteResult.Succeeded)
                return Response<bool>.SetCustomErrorResponse(
                    string.Join(", ", deleteResult.Errors.Select(error => error.Description)), 500);

            return Response<bool>.SetSuccessResponse(true);
        }

        public async Task<Response<bool>> RemoveRoleAsync(int userId, string roleId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null)
                return Response<bool>.UserNotFoundResponse();

            var role = await _roleManager.FindByIdAsync(roleId);
            if (role == null || role.Name == null)
                return Response<bool>.SetCustomErrorResponse("Role not found", 500);

            var removeRoleResult = await _userManager.RemoveFromRoleAsync(user, role.Name);

            if (!removeRoleResult.Succeeded)
                return Response<bool>.SetCustomErrorResponse(
                    string.Join(", ", removeRoleResult.Errors.Select(error => error.Description)), 500);

            return Response<bool>.SetSuccessResponse(true);
        }

        public async Task<Response<bool>> ActivateDeactivateAsync(int userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null)
                return Response<bool>.UserNotFoundResponse();

            user.LockoutEnabled = !user.LockoutEnabled;
            var updateResult = await _userManager.UpdateAsync(user);
            if (!updateResult.Succeeded)
                return Response<bool>.SetCustomErrorResponse(
                    string.Join(", ", updateResult.Errors.Select(error => error.Description)), 500);

            return Response<bool>.SetSuccessResponse(user.LockoutEnabled);
        }

        public async Task<Response<List<string>>> GetRolesByUserIdAsync(int userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null)
                return Response<List<string>>.UserNotFoundResponse();

            var userRoles = await _userManager.GetRolesAsync(user);
            return Response<List<string>>.SetSuccessResponse(userRoles.ToList());
        }
    }
}