namespace GAC.Application.Services.Identity.Dtos.User
{
    public class UserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string FirstNameEn { get; set; } = string.Empty;
        public string FirstNameAr { get; set; } = string.Empty;

        public string LastNameAr { get; set; } = string.Empty;
        public string LastNameEn { get; set; } = string.Empty;

        public bool IsActive { get; set; }
        public List<string> Roles { get; set; } = new();
    }
}