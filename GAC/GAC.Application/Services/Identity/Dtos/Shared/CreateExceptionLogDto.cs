namespace GAC.Application.Services.Identity.Dtos.Shared
{
    public class CreateExceptionLogDto
    {
        public string LogLevel { get; set; } 
        public string Message { get; set; }
        public string Exception { get; set; }
        public string StackTrace { get; set; }
        public string RequestUrl { get; set; }
        public string RequestMethod { get; set; }
        public string IPAddress { get; set; }
        public string ApplicationName { get; set; }
        public int? UserId { get; set; } 
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
