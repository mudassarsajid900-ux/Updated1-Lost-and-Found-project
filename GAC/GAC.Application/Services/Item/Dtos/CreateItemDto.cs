using GAC.Core.Enums;
using Microsoft.AspNetCore.Http;

namespace GAC.Application.Services.Item.Dtos
{
    public class CreateItemDto
    {
        public DateTime EventTime { get; set; }

        public long LocationId { get; set; }

        public long ItemTypeId { get; set; }

        public ItemStatus Status { get; set; }
        public ReportType ReportType { get; set; }
        public IFormFile? Photo { get; set; }
        public List<CreateItemAttributeDto> Attributes { get; set; }
    }
}
