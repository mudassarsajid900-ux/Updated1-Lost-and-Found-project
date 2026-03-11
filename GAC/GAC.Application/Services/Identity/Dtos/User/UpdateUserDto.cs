namespace GAC.Application.Services.Identity.Dtos.User
{
    public class UpdateUserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string FirstNameAr { get; set; } = "";
        public string LastName { get; set; } = "";
        public string LastNameAr { get; set; } = "";
        public string Email { get; set; } = "";
        public string? Password { get; set; }  
        public int? RoleId { get; set; }
    }
}