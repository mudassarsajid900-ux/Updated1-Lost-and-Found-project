using GAC.Application.Services.Identity.Dtos.Auth;
using GAC.Application.Services.Identity.Dtos.User;
using GAC.Common.Responce;

namespace GAC.Application.Interfaces.Identity
{
    public interface IAuthService
    {
        Task<Response<UserDetailsDto>> LoginAsync(LoginDto loginDto);
        Task<AuthDto?> LoginAsync(LoginDto model, bool isApiLogin = false);
        Task<AuthDto> RefreshTokenAsync(string refreshToken);
        Task RevokeRefreshTokenAsync(int userId);
        Task RegisterAsync(RegisterDto model);
        Task<Response<bool>> ChangePasswordAsync(ChangePasswordDto model);
    }
}