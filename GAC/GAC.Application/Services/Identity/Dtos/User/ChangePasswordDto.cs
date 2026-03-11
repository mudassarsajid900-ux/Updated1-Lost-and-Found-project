namespace GAC.Application.Services.Identity.Dtos.User
{
    public class ChangePasswordDto
    {
        public string Email { get; set; } = string.Empty;
        public string CurrentPassword { get; set; } = string.Empty;
        public string NewPassword { get; set; } = string.Empty;
    }
}
