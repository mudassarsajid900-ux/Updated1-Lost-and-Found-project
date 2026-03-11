using GAC.Application.Interfaces.Identity;
using GAC.Application.Interfaces.Shared;
using GAC.Common;
using GAC.Common.Constants;
using GAC.Common.Constants.Common;
using GAC.Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace GAC.Application.Services.Identity
{
    public class JwtTokenService : IJwtTokenService
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly JwtSettings _jwtSettings;
        private readonly IGenericRepository<ApplicationUser> _userRepository;
        private readonly IUserManagementService _userService;
        public JwtTokenService(IConfiguration configuration, UserManager<ApplicationUser> userManager,
            IOptionsMonitor<JwtSettings> jwtSettings,
            IGenericRepository<ApplicationUser> userRepository, IUserManagementService userService)
        {
            _configuration = configuration;
            _userManager = userManager;
            _jwtSettings = jwtSettings.CurrentValue;
            _userRepository = userRepository;
            _userService = userService;
        }


        public async Task<string> GenerateTokenAsync(string email, IList<System.Security.Claims.Claim>? additionalClaims = null)
        {
            if (string.IsNullOrWhiteSpace(email))
                return string.Empty;

            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return string.Empty;

            var jwtSettings = _configuration.GetSection("JwtSettings").Get<JwtSettings>();
            if (string.IsNullOrWhiteSpace(jwtSettings.Key) || jwtSettings.Key.Length < 16)
                throw new InvalidOperationException("Invalid JWT signing key.");

            var claims = new List<System.Security.Claims.Claim>
            {
                new System.Security.Claims.Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new System.Security.Claims.Claim(JwtRegisteredClaimNames.Email, user.Email ?? string.Empty),
                new System.Security.Claims.Claim(JwtRegisteredClaimNames.Name, user.UserName ?? string.Empty),
                new System.Security.Claims.Claim(CommonText.UserId, user.Id.ToString()),
               
            };


            var roles = await _userManager.GetRolesAsync(user);
            claims.AddRange(roles.Select(role => new System.Security.Claims.Claim(ClaimTypes.Role, role)));

            if (additionalClaims != null)
            {
                foreach (var claim in additionalClaims)
                {
                    if (!claims.Any(c => c.Type == claim.Type && c.Value == claim.Value))
                        claims.Add(claim);
                }
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: jwtSettings.Issuer,
                audience: jwtSettings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(jwtSettings.TokenExpirationInMinutes),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        
        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[64];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }

        public ClaimsPrincipal? GetPrincipalFromExpiredToken(string? token)
        {
            var jwtSettings = _configuration.GetSection(CommonText.JwtSettings).Get<JwtSettings>();

            // Disable default mapping so "email" stays as is
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key)),
                ValidateLifetime = false, // Allow expired tokens
                NameClaimType = "email"   // Treat "email" as the main Name claim
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);

            if (securityToken is not JwtSecurityToken jwtSecurityToken ||
                !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new SecurityTokenException(ErrorConstants.InvalidToken);
            }

            return principal;
        }


        private JwtSecurityToken ParseIdToken(string idToken)
        {
            var handler = new JwtSecurityTokenHandler();
            return handler.ReadJwtToken(idToken);
        }

    }
}
