// ========================================== //
// SECTION: IDENTITY SERVICES
// DESCRIPTION: Core Authentication and Authorization Logic
// ========================================== //
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
    /// <summary>
    /// Orchestrates all security-related operations including JWT issuance, 
    /// refresh token lifecycle management, and user registration verification.
    /// Implements IAuthService for loose coupling.
    /// </summary>
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

        /// <summary>
        /// Authenticates a user and returns detailed metadata within a Response wrapper.
        /// Primarily used by internal management services requiring a structured response.
        /// </summary>
        public async Task<Response<UserDetailsDto>> LoginAsync(LoginDto model)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null || !user.IsActive || !await _userManager.CheckPasswordAsync(user, model.Password))
                {
                    return Response<UserDetailsDto>.SetCustomErrorResponse("Identity Error: Invalid Email or Password.", StatusCodes.Status401Unauthorized);
                }

                var roles = await _userManager.GetRolesAsync(user);
                var userDetails = _mapper.Map<UserDetailsDto>(user);
                userDetails.Roles = roles.ToList();

                // Generate a session token for this variant as well to ensure parity
                var claims = new List<System.Security.Claims.Claim>
                {
                    new(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                    new(JwtRegisteredClaimNames.Email, user.Email ?? string.Empty),
                    new(ClaimTypes.Name, user.UserName ?? "GuestUser"),
                    new(ClaimTypes.NameIdentifier, user.Id.ToString())
                };
                claims.AddRange(roles.Select(r => new System.Security.Claims.Claim(ClaimTypes.Role, r)));
                
                userDetails.AccessToken = GenerateJwtToken(claims);

                return Response<UserDetailsDto>.SetSuccessResponse(userDetails, "Authentication successful.");
            }
            catch (Exception ex)
            {
                await LogAndThrowAsync(ex, "/api/auth/login-basic");
                return Response<UserDetailsDto>.SetCustomErrorResponse("A technical failure occurred during authentication.", StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Authenticates a user based on email and password.
        /// Supports both Web (Cookie-based) and API (JWT-based) authentication flows.
        /// </summary>
        /// <param name="model">Credentials DTO containing Email and Password.</param>
        /// <param name="isApiLogin">Flag to determine whether to return a JWT (for mobile/web app).</param>
        /// <returns>AuthDto containing user metadata and tokens if successful; null otherwise.</returns>
        public async Task<AuthDto?> LoginAsync(LoginDto model, bool isApiLogin = false)
        {
            try
            {
                // 1. Locate user by email and verify active status
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null || !user.IsActive || !await _userManager.CheckPasswordAsync(user, model.Password))
                {
                    // Security Trace: Log failed attempts for audit detection
                    await _exceptionLogService.LogAsync(BuildLogDto(
                        new Exception("Invalid authentication attempt"),
                        isApiLogin ? "/api/auth/login" : "/account/login"
                    ));

                    return null; 
                }

                // 2. Aggregate user identity claims
                var roles = await _userManager.GetRolesAsync(user);
                var authDto = new AuthDto
                {
                    Username = user.UserName ?? string.Empty,
                    Email = user.Email ?? string.Empty,
                    Roles = roles.ToList()
                };

                // 3. Handle Token Issuance for API Clients (React/Mobile)
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

                    // Generate long-lived refresh token and short-lived access token
                    authDto.Token = GenerateJwtToken(claims);
                    authDto.RefreshToken = GenerateRefreshToken();
                    authDto.RefreshTokenExpiry = DateTime.UtcNow.AddDays(_jwtSettings.RefreshTokenExpirationInDays);

                    // Update User Record with current session credentials
                    user.RefreshToken = authDto.RefreshToken;
                    user.RefreshTokenExpiryTime = (DateTime)authDto.RefreshTokenExpiry;
                    await _userManager.UpdateAsync(user);
                }
                else
                {
                    // Fallback for internal management portal (Cookie-based)
                    await _signInManager.SignInAsync(user, isPersistent: false);
                }

                return authDto;
            }
            catch (Exception ex)
            {
                await LogAndThrowAsync(ex, isApiLogin ? "/api/auth/login" : "/account/login");
                throw;
            }
        }

        /// <summary>
        /// Rotates an expired access token using a valid refresh token.
        /// Implements security best practices by rotating the refresh token itself upon each use.
        /// </summary>
        public async Task<AuthDto> RefreshTokenAsync(string refreshToken)
        {
            try
            {
                // Verify token authenticity and expiry
                var user = await _userManager.Users
                    .FirstOrDefaultAsync(u => u.RefreshToken == refreshToken);

                if (user == null || user.RefreshTokenExpiryTime <= DateTime.UtcNow)
                    throw new UnauthorizedAccessException("Session has expired. Please log in again.");

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

                // Rotate both tokens for maximum security
                var newAccessToken = GenerateJwtToken(claims);
                var newRefreshToken = GenerateRefreshToken();
                var newRefreshTokenExpiry = DateTime.UtcNow.AddDays(_jwtSettings.RefreshTokenExpirationInDays);

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

        /// <summary>
        /// Forcefully invalidates a user's session.
        /// Useful for administrative suspension or global logout.
        /// </summary>
        public async Task RevokeRefreshTokenAsync(int userId)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(userId.ToString());
                if (user == null)
                    throw new ArgumentException("Security Breach Attempt: Revoke called for non-existent user.");

                user.RefreshToken = null;
                user.RefreshTokenExpiryTime = DateTime.UtcNow.AddSeconds(-1); // Expire immediately
                await _userManager.UpdateAsync(user);
            }
            catch (Exception ex)
            {
                await LogAndThrowAsync(ex, "/api/auth/revoke");
            }
        }

        /// <summary>
        /// Handles student self-registration and assigns the default 'User' permission profile.
        /// </summary>
        public async Task RegisterAsync(RegisterDto model)
        {
            try
            {
                var user = _mapper.Map<ApplicationUser>(model);
                var result = await _userManager.CreateAsync(user, model.Password);

                if (!result.Succeeded)
                {
                    var errors = string.Join("; ", result.Errors.Select(e => e.Description));
                    throw new ApplicationException($"Identity Error: {errors}");
                }

                // Default Role Assignment: Every student gets basic user access
                if (await _roleManager.RoleExistsAsync("User"))
                {
                    var roleResult = await _userManager.AddToRoleAsync(user, "User");
                    if (!roleResult.Succeeded)
                    {
                        var errors = string.Join("; ", roleResult.Errors.Select(e => e.Description));
                        throw new ApplicationException($"System Permission Error: {errors}");
                    }
                }
            }
            catch (Exception ex)
            {
                await LogAndThrowAsync(ex, "/api/auth/register");
            }
        }

        /// <summary>
        /// Verifies current password and updates it with the new value.
        /// Returns a structured Response for direct propagation to controllers.
        /// </summary>
        public async Task<Response<bool>> ChangePasswordAsync(ChangePasswordDto model)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                    return Response<bool>.SetCustomErrorResponse("Identity Error: Account not found.", StatusCodes.Status404NotFound);

                var result = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
                if (result.Succeeded)
                {
                    return Response<bool>.SetSuccessResponse(true, "Your password has been securely updated.");
                }

                var errors = string.Join("; ", result.Errors.Select(e => e.Description));
                return Response<bool>.SetCustomErrorResponse(errors, StatusCodes.Status400BadRequest);
            }
            catch (Exception ex)
            {
                await LogAndThrowAsync(ex, "/api/auth/change-password");
                return Response<bool>.SetCustomErrorResponse("A technical error occurred during credential update.", StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Generates a signed JWT byte sequence for secure client-server data exchange.
        /// Uses HmacSha256 for integrity verification.
        /// </summary>
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
                LogAndThrowAsync(ex, "Security Core: GenerateJwtToken").ConfigureAwait(false);
                throw;
            }
        }

        /// <summary>
        /// Creates a cryptographically strong random string for use as a refresh token.
        /// </summary>
        private string GenerateRefreshToken()
        {
            var randomNumber = new byte[64];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }

        /// <summary>
        /// Serializes the refresh token into a secure HTTP-Only cookie.
        /// Used primarily by the CMS portal for seamless session persistence.
        /// </summary>
        private void SetRefreshTokenCookie(string refreshToken, DateTime expiry)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true, 
                Expires = expiry,
                Secure = true, // Enforce HTTPS for cookie transmission
                SameSite = SameSiteMode.Strict, // Mitigate CSRF risks
                IsEssential = true
            };

            _httpContextAccessor.HttpContext?.Response.Cookies.Append(
                "RefreshToken",
                refreshToken,
                cookieOptions);
        }

        /// <summary>
        /// Centralized exception logging and propagation handler.
        /// </summary>
        private async Task LogAndThrowAsync(Exception ex, string fallbackUrl)
        {
            var logDto = BuildLogDto(ex, fallbackUrl);

            try
            {
                await _exceptionLogService.LogAsync(logDto);
            }
            catch
            {
                // Resilience: Do not allow logging failures to mask core security events
            }
        }

        /// <summary>
        /// Inspects the HTTP request context to build a rich exception log DTO.
        /// Captures IP Address, Method, and Path for forensic analysis.
        /// </summary>
        private CreateExceptionLogDto BuildLogDto(Exception ex, string fallbackUrl)
        {
            var context = _httpContextAccessor.HttpContext;
            var request = context?.Request;

            var path = request?.Path.Value ?? fallbackUrl;
            var method = request?.Method ?? "INTERNAL";
            var ip = context?.Connection.RemoteIpAddress?.ToString() ?? "Loopback";

            var isApi = path?.StartsWith("/api", StringComparison.OrdinalIgnoreCase) == true;
            var appName = isApi ? "GAC_API" : "GAC_PORTAL";

            return new CreateExceptionLogDto
            {
                LogLevel = "CRITICAL_ERROR",
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