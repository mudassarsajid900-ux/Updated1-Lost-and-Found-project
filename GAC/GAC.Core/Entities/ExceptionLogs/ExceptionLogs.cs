using System.ComponentModel.DataAnnotations;

namespace GAC.Core.Entities.ExceptionLogs
{
    public class ExceptionLogs
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string LogLevel { get; set; } 
        public string? Message { get; set; }

        [StringLength(4000)]
        public string Exception { get; set; }

        [StringLength(4000)]
        public string StackTrace { get; set; }

        [StringLength(1000)]
        public string RequestUrl { get; set; }

        [StringLength(100)]
        public string RequestMethod { get; set; }

        [StringLength(100)]
        public string IPAddress { get; set; }

        [StringLength(100)]
        public string ApplicationName { get; set; }
        public int UserId { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
