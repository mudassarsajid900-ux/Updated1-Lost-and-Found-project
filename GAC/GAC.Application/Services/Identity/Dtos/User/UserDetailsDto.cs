namespace GAC.Application.Services.Identity.Dtos.User
{
    public class UserDetailsDto
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public List<string> Roles { get; set; }
        public bool EmailConfirmed { get; set; }
        public DateTime LastLogin { get; set; }
        public DateTime AccountCreated { get; set; }
        public IList<string>? Permissions { get; set; }
        public bool IsLockedOut { get; set; }

        public bool IsSheikh { get; set; }
        public bool IsHeadOffice { get; set; }
    }
}
