using GAC.Core.Enums;

namespace GAC.Application.Services.Item.Dtos
{
    public class UpdateItemDto
    {
        public long Id { get; set; }

        public DateTime EventTime { get; set; }

        public long LocationId { get; set; }

        public long ItemTypeId { get; set; }

        public ItemStatus Status { get; set; }

        public List<UpdateItemAttributeDto> Attributes { get; set; }
    }
}
