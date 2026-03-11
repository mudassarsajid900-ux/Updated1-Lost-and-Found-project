using GAC.Core.Enums;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
namespace GAC.Application.Helper
{
    public class UserData
    {
        public UserData(IHttpContextAccessor httpContextAccessor)
        {
            var httpContext = httpContextAccessor.HttpContext;

            var claims = httpContext?.User?.Claims;

            Email = claims?.FirstOrDefault(x => x.Type == ClaimTypes.Email || x.Type == "email")?.Value ?? string.Empty;
            
            var userIdClaim = claims?.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value 
                     ?? claims?.FirstOrDefault(x => x.Type == "sub")?.Value
                     ?? claims?.FirstOrDefault(x => x.Type == "user_id")?.Value;

            if (int.TryParse(userIdClaim, out var parsedUserId))
            {
                UserId = parsedUserId;
            }

            UserRoleIdentifier = claims?.FirstOrDefault(x => x.Type == "UserRoleIdentifier")?.Value ?? string.Empty;
            UserFullNameEn = claims?.FirstOrDefault(x => x.Type == "UserFullNameEn")?.Value ?? string.Empty;
            UserFullNameAr = claims?.FirstOrDefault(x => x.Type == "UserFullNameAr")?.Value ?? string.Empty;

            var orgIdClaim = claims?.FirstOrDefault(x => x.Type == "organization_id")?.Value;
            OrganzationId = long.TryParse(orgIdClaim, out var orgId) ? orgId : null;

            var appUserOrgIdClaim = claims?.FirstOrDefault(x => x.Type == "app_user_organization_id")?.Value;
            ApplicationUserOrganzationId = long.TryParse(appUserOrgIdClaim, out var appUserOrgId) ? appUserOrgId : null;

            UserPosition = claims?.FirstOrDefault(x => x.Type == "UserPosition")?.Value;

        }

        public int UserId { get; set; }
        public LanguageCode LangCode { get; set; } = LanguageCode.En;
        public string Email { get; set; } = string.Empty;
        public string Roles { get; set; } = string.Empty;
        public string ParentEntityId { get; set; } = string.Empty;
        public long? OrganzationId { get; set; }
        public long? ApplicationUserOrganzationId { get; set; }

        public string? UserPosition { get; set; }
        public string UserRoleIdentifier { get; set; } = string.Empty;
        public string JwtToken { get; set; } = string.Empty;
        public string UserFullNameEn { get; set; } = string.Empty;
        public string UserFullNameAr { get; set; } = string.Empty;

    }
}
