using GAC.Application.Services.Identity.Dtos.User;
using GAC.Common.Pagination;
using GAC.Common.Responce;
namespace GAC.Application.Interfaces.Identity
{
    public interface IUserManagementService
    {
        Task<(IEnumerable<UserDto> Users, int TotalCount)> GetUsersAsync(DataTableRequest request);
        Task<Response<UserDto>> GetUserByIdAsync(int userId);
        Task<Response<bool>> UserExistsAsync(string emailOrUsername);
        Task<Response<bool>> CreateUserAsync(CreateUserDto dto);
        Task<Response<bool>> UpdateUserAsync(UpdateUserDto dto);
        Task<Response<bool>> DeleteUserAsync(int userId);
        Task<Response<bool>> RemoveRoleAsync(int userId, string roleName);
        Task<Response<bool>> ActivateDeactivateAsync(int userId);
        Task<Response<List<string>>> GetRolesByUserIdAsync(int userId);
    }
}