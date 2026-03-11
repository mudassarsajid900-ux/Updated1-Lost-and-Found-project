using System.ComponentModel.DataAnnotations;

namespace GAC.Core.Entities.ExceptionLogs
{
    public class AuditLogs
    {
        public long Id { get; set; }

        [StringLength(300)]
        public string Action { get; set; }

        [StringLength(300)]
        public string EntityName { get; set; }
        public DateTime Timestamp { get; set; }

        [StringLength(2000)]
        public string Details { get; set; }

        [StringLength(100)]
        public string ApplicationName { get; set; }
        public int UserId { get; set; }

        [StringLength(100)]
        public string? UserName { get; set; }
    }
}
