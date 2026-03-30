using GAC.Application.Services.Item.Dtos;
using System.Collections.Generic;

namespace GAC.Application.Services.Item.Dtos
{
    public class PagedItemResponseDto
    {
        public List<GetItemDto> Items { get; set; } = new();
        public int Total { get; set; }
        public int LostCount { get; set; }
        public int FoundCount { get; set; }
        public int MatchCount { get; set; }
    }
}
