using System.Collections.Generic;

namespace GAC.Application.Services.Item.Dtos
{
    public class GetItemTypeDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<GetFieldDto> Fields { get; set; } = new List<GetFieldDto>();
    }

    public class GetFieldDto
    {
        public long Id { get; set; }
        public string FieldName { get; set; }
    }

    public class CreateItemTypeDto
    {
        public string Name { get; set; } = string.Empty;
        public List<CreateFieldDto> Fields { get; set; } = new List<CreateFieldDto>();
    }

    public class CreateFieldDto
    {
        public string FieldName { get; set; } = string.Empty;
    }
}
