using GAC.Application.Services.Item.Dtos;
using GAC.Common.Responce;

namespace GAC.Application.Interfaces.Item
{
    public interface IItemService
    {
        Task<Response<GetItemDto>> CreateAsync(CreateItemDto dto);
        Task<Response<GetItemDto>> UpdateAsync(UpdateItemDto dto);
        Task<Response<GetItemDto>> GetByIdAsync(long id);
        Task<Response<PagedItemResponseDto>> GetAllAsync(int start = 0, int length = 50, string tab = "all", string? search = null);
        Task<Response<List<GetItemDto>>> GetMyItemsAsync();
        Task<Response<List<GetItemDto>>> GetPublicFoundItemsAsync();
        Task<Response<string>> DeleteAsync(long id);
        Task<Response<bool>> VerifyItemAsync(long id);
        Task<Response<bool>> MoveToAuctionAsync(long id);
    }
}
