using GAC.Application.Services.Item.Dtos;
using GAC.Common.Responce;

namespace GAC.Application.Interfaces.Item
{
    public interface IItemTypeService
    {
        Task<Response<List<GetItemTypeDto>>> GetAllAsync();
    }
}
