using GAC.Common.Constants;
using GAC.Core.Enums;
using System.Collections.Generic;

namespace GAC.Application.Services.Item.Dtos
{
    public class GetItemDto : BaseDto
    {
        public DateTime EventTime { get; set; }
        public string LocationName { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public List<GetItemAttributes> Attributes { get; set; } = new();

        public ItemStatus Status { get; set; }
        public ReportType ReportType { get; set; }
        public string ImageUrl { get; set; }

        public bool HasPotentialMatch { get; set; } = false;
        public long? MatchFoundItemId { get; set; }
        public bool IsVerifiedByAdmin { get; set; } = false;
    }
}
