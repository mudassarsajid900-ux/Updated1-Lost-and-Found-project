using System.Security.Claims;

namespace GAC.Application.Interfaces.Identity
{
    public interface IJwtTokenService
    {
        Task<string> GenerateTokenAsync(string username, IList<Claim>? additionalClaims = null);
        string GenerateRefreshToken();
        ClaimsPrincipal? GetPrincipalFromExpiredToken(string? token);

    }
}
