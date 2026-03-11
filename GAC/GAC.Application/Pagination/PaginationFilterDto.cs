using Swashbuckle.AspNetCore.Annotations;
using System.Text.Json.Serialization;

namespace GAC.Application.Pagination
{
    public  class PaginationFilterDto
    {
        public string? SearchValue { get; set; }
        [JsonIgnore][SwaggerIgnore] public string? SortColumn { get; set; }
        [JsonIgnore]
        [SwaggerIgnore]
        public string SortDirection { get; set; } = "DESC";
        public int PageSize { get; set; } = 10;
        public int PageNumber { get; set; } = 1;

        [SwaggerSchema(ReadOnly = true, Description = "Used internally for pagination and hidden in Swagger")]
        [JsonIgnore]
        [SwaggerIgnore]
        public int Skip => (PageNumber - 1) * PageSize;
    }
}
