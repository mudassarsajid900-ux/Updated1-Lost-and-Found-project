using GAC.Application.Services.Item.Dtos;
using GAC.Common.Responce;

namespace GAC.Application.Interfaces.Item
{
    public interface IItemService
    {
        Task<Response<GetItemDto>> CreateAsync(CreateItemDto dto);
        Task<Response<GetItemDto>> UpdateAsync(UpdateItemDto dto);
        Task<Response<GetItemDto>> GetByIdAsync(long id);
        Task<Response<List<GetItemDto>>> GetAllAsync();
        Task<Response<List<GetItemDto>>> GetMyItemsAsync();
        Task<Response<List<GetItemDto>>> GetPublicFoundItemsAsync();
        Task<Response<string>> DeleteAsync(long id);
    }
}
