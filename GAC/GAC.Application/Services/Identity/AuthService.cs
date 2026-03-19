using AutoMapper;
using GAC.Application.Interfaces.Identity;
using GAC.Application.Interfaces.Shared;
using GAC.Application.Services.Identity.Dtos.Auth;
using GAC.Application.Services.Identity.Dtos.Shared;
using GAC.Application.Services.Identity.Dtos.User;
using GAC.Common;
using GAC.Common.Responce;
using GAC.Core.Entities.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace GAC.Application.Services.Identity
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;
        private readonly JwtSettings _jwtSettings;
        private readonly IExceptionLogService _exceptionLogService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IJwtTokenService _jwtTokenService;

        public AuthService(
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            SignInManager<ApplicationUser> signInManager,
            IMapper mapper,
            IOptions<JwtSettings> jwtOptions,
            IExceptionLogService exceptionLogService,
            IHttpContextAccessor httpContextAccessor,
            IJwtTokenService jwtTokenService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _jwtSettings = jwtOptions?.Value ?? throw new InvalidOperationException("JwtSettings not configured.");
            _exceptionLogService = exceptionLogService;
            _httpContextAccessor = httpContextAccessor;
            _jwtTokenService = jwtTokenService;
        }

        public async Task<Response<UserDetailsDto>> LoginAsync(LoginDto loginDto)
        {
            // 1. Validate user
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            if (user == null)
                return Response<UserDetailsDto>.SetCustomErrorResponse("User not Found", StatusCodes.Status401Unauthorized);

            if (!user.IsActive)
                return Response<UserDetailsDto>.SetCustomErrorResponse("Your account is deactivated. Please contact the administrator.", StatusCodes.Status403Forbidden);

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);
            if (!result.Succeeded)
                return Response<UserDetailsDto>.SetCustomErrorResponse("Invalid_Credentials", StatusCodes.Status401Unauthorized);

            UserDeviceToken deviceEntity = null;

            // 3. Get user roles and claims
            var roles = await _userManager.GetRolesAsync(user);
            var roleName = roles.First();
            var role = await _roleManager.FindByNameAsync(roleName);
            if (role == null)
                return Response<UserDetailsDto>.SetCustomErrorResponse("User not Found", StatusCodes.Status401Unauthorized);

            var roleClaims = await _roleManager.GetClaimsAsync(role);
            var claims = new List<System.Security.Claims.Claim>(roleClaims)
    {
        new System.Security.Claims.Claim(ClaimTypes.Name, user.UserName),
        new System.Security.Claims.Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
        new System.Security.Claims.Claim("UserFullName", $"{user.FirstName}{user.LastName}" ?? string.Empty),
        new System.Security.Claims.Claim("Role",roleName),
        
    };

            if (deviceEntity != null)
                claims.Add(new System.Security.Claims.Claim("deviceToken", deviceEntity.DeviceToken));

            // 4. Generate JWT
            var token = await _jwtTokenService.GenerateTokenAsync(loginDto.Email, claims);

            // 5. Prepare response
            var userDetails = new UserDetailsDto
            {
                AccessToken = token,
                Id = user.Id,
                Username = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                TwoFactorEnabled = user.TwoFactorEnabled,
                Roles = roles.ToList(),
                EmailConfirmed = user.EmailConfirmed,
                LastLogin = DateTime.UtcNow,
                AccountCreated = user.LockoutEnd.HasValue ? user.LockoutEnd.Value.UtcDateTime : DateTime.UtcNow,
                IsLockedOut = user.LockoutEnabled && user.LockoutEnd > DateTimeOffset.UtcNow
             
            };

            return Response<UserDetailsDto>.SetSuccessResponse(userDetails, "Login_Successful");
        }



        public async Task<AuthDto?> LoginAsync(LoginDto model, bool isApiLogin = false)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null || !user.IsActive || !await _userManager.CheckPasswordAsync(user, model.Password))
                {
                    // Log failed attempt
                    await _exceptionLogService.LogAsync(BuildLogDto(
                        new Exception("Invalid username or password"),
                        isApiLogin ? "/api/auth/login" : "/account/login"
                    ));

                    return null; // <-- return null instead of throwing
                }

                var roles = await _userManager.GetRolesAsync(user);
                var authDto = new AuthDto
                {
                    Username = user.UserName ?? string.Empty,
                    Email = user.Email ?? string.Empty,
                    Roles = roles.ToList()
                };

                if (isApiLogin)
                {
                    var claims = new List<System.Security.Claims.Claim>
            {
                new(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new(JwtRegisteredClaimNames.Email, user.Email ?? string.Empty),
                new(ClaimTypes.Name, user.UserName ?? "GuestUser"),
                new(ClaimTypes.NameIdentifier, user.Id.ToString())
            };
                    claims.AddRange(roles.Select(r => new System.Security.Claims.Claim(ClaimTypes.Role, r)));

                    authDto.Token = GenerateJwtToken(claims);
                    authDto.RefreshToken = GenerateRefreshToken();
                    authDto.RefreshTokenExpiry = DateTime.UtcNow.AddDays(_jwtSettings.RefreshTokenExpirationInDays);

                    user.RefreshToken = authDto.RefreshToken;
                    user.RefreshTokenExpiryTime = (DateTime)authDto.RefreshTokenExpiry;
                    await _userManager.UpdateAsync(user);
                }
                else
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                }

                return authDto;
            }
            catch (Exception ex)
            {
                // Unexpected errors still log and rethrow
                await LogAndThrowAsync(ex, isApiLogin ? "/api/auth/login" : "/account/login");
                throw;
            }
        }

        public async Task<AuthDto> RefreshTokenAsync(string refreshToken)
        {
            try
            {
                var user = await _userManager.Users
                    .FirstOrDefaultAsync(u => u.RefreshToken == refreshToken);

                if (user == null || user.RefreshTokenExpiryTime <= DateTime.UtcNow)
                    throw new UnauthorizedAccessException("Invalid or expired refresh token.");

                var roles = await _userManager.GetRolesAsync(user);

                var claims = new List<System.Security.Claims.Claim>
                {
                    new(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                    new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new(JwtRegisteredClaimNames.Email, user.Email ?? string.Empty),
                    new(ClaimTypes.Name, user.UserName ?? "GuestUser"),
                    new(ClaimTypes.NameIdentifier, user.Id.ToString())
                };
                claims.AddRange(roles.Select(r => new System.Security.Claims.Claim(ClaimTypes.Role, r)));

                var newAccessToken = GenerateJwtToken(claims);
                var newRefreshToken = GenerateRefreshToken();
                var newRefreshTokenExpiry = DateTime.UtcNow.AddDays(_jwtSettings.RefreshTokenExpirationInDays);

                // Update refresh token
                user.RefreshToken = newRefreshToken;
                user.RefreshTokenExpiryTime = newRefreshTokenExpiry;
                await _userManager.UpdateAsync(user);

                return new AuthDto
                {
                    Username = user.UserName ?? string.Empty,
                    Email = user.Email ?? string.Empty,
                    Roles = roles.ToList(),
                    Token = newAccessToken,
                    RefreshToken = newRefreshToken,
                    RefreshTokenExpiry = newRefreshTokenExpiry
                };
            }
            catch (Exception ex)
            {
                await LogAndThrowAsync(ex, "/api/auth/refresh");
                return null!;
            }
        }

        public async Task RevokeRefreshTokenAsync(int userId)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(userId.ToString());
                if (user == null)
                    throw new ArgumentException("User not found.");

                user.RefreshToken = null;
                user.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);
                await _userManager.UpdateAsync(user);
            }
            catch (Exception ex)
            {
                await LogAndThrowAsync(ex, "/api/auth/revoke");
            }
        }

        public async Task RegisterAsync(RegisterDto model)
        {
            try
            {
                var user = _mapper.Map<ApplicationUser>(model);
                var result = await _userManager.CreateAsync(user, model.Password);

                if (!result.Succeeded)
                {
                    var errors = string.Join("; ", result.Errors.Select(e => e.Description));
                    throw new ApplicationException($"Registration failed: {errors}");
                }

                if (await _roleManager.RoleExistsAsync("User"))
                {
                    var roleResult = await _userManager.AddToRoleAsync(user, "User");
                    if (!roleResult.Succeeded)
                    {
                        var errors = string.Join("; ", roleResult.Errors.Select(e => e.Description));
                        throw new ApplicationException($"Failed to assign role 'User': {errors}");
                    }
                }
            }
            catch (Exception ex)
            {
                await LogAndThrowAsync(ex, "/api/auth/register");
            }
        }

        public async Task<Response<bool>> ChangePasswordAsync(ChangePasswordDto model)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                    return Response<bool>.SetCustomErrorResponse("User not found.", StatusCodes.Status404NotFound);

                var result = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
                if (result.Succeeded)
                {
                    return Response<bool>.SetSuccessResponse(true, "Password changed successfully.");
                }

                var errors = string.Join("; ", result.Errors.Select(e => e.Description));
                return Response<bool>.SetCustomErrorResponse(errors, StatusCodes.Status400BadRequest);
            }
            catch (Exception ex)
            {
                await LogAndThrowAsync(ex, "/api/auth/change-password");
                return Response<bool>.SetCustomErrorResponse("An error occurred while changing password.", StatusCodes.Status500InternalServerError);
            }
        }

        private string GenerateJwtToken(IEnumerable<System.Security.Claims.Claim> claims)
        {
            try
            {
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: _jwtSettings.Issuer,
                    audience: _jwtSettings.Audience,
                    claims: claims,
                    expires: DateTime.UtcNow.AddMinutes(_jwtSettings.TokenExpirationInMinutes),
                    signingCredentials: creds);

                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            catch (Exception ex)
            {
                LogAndThrowAsync(ex, "GenerateJwtToken").ConfigureAwait(false);
                throw;
            }
        }

        private string GenerateRefreshToken()
        {
            var randomNumber = new byte[64];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }

        private void SetRefreshTokenCookie(string refreshToken, DateTime expiry)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = expiry,
                Secure = true, // Set to true in production with HTTPS
                SameSite = SameSiteMode.Strict,
                IsEssential = true
            };

            _httpContextAccessor.HttpContext?.Response.Cookies.Append(
                "RefreshToken",
                refreshToken,
                cookieOptions);
        }

        private async Task LogAndThrowAsync(Exception ex, string fallbackUrl)
        {
            var logDto = BuildLogDto(ex, fallbackUrl);

            try
            {
                await _exceptionLogService.LogAsync(logDto);
            }
            catch
            {
                // Silently fail logging
            }

            throw ex;
        }

        private CreateExceptionLogDto BuildLogDto(Exception ex, string fallbackUrl)
        {
            var context = _httpContextAccessor.HttpContext;
            var request = context?.Request;

            var path = request?.Path.Value ?? fallbackUrl;
            var method = request?.Method ?? "UNKNOWN";
            var ip = context?.Connection.RemoteIpAddress?.ToString() ?? "N/A";

            var isApi = path?.StartsWith("/api", StringComparison.OrdinalIgnoreCase) == true;
            var appName = isApi ? "API" : "CMS";

            return new CreateExceptionLogDto
            {
                LogLevel = "ERROR",
                Message = ex.Message,
                Exception = $"{ex.GetType().Name}: {ex.Message}",
                StackTrace = ex.StackTrace ?? string.Empty,
                RequestUrl = path,
                RequestMethod = method,
                IPAddress = ip,
                CreatedAt = DateTime.UtcNow,
                ApplicationName = appName
            };
        }
    }
}