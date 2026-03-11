using GAC.Common.Constants;

namespace GAC.Application.Services.Item.Dtos
{
    public class UpdateItemAttributeDto : BaseDto
    {
        public string FieldName { get; set; }

        public string FieldValue { get; set; }
    }
}
