namespace GAC.Application.Services.Identity.Dtos.Auth
{
    public class LoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public string? DeviceInfo { get; set; }
        public string? DeviceType { get; set; }
        public string? UserTimeZone { get; set; }
        public bool ForceNewDevice { get; set; } = false;
    }
}
