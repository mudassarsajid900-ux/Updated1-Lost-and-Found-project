using GAC.Application.Services.Handover.Dtos;
using GAC.Common.Responce;

namespace GAC.Application.Interfaces.Handover
{
    public interface IHandoverService
    {
        Task<Response<GetHandoverDto>> CreateHandoverAsync(CreateHandoverDto dto);
        Task<Response<List<GetHandoverDto>>> GetAllHandoversAsync();
        Task<Response<GetHandoverDto>> GetByIdAsync(long id);
        Task<Response<List<PendingHandoverDto>>> GetPendingHandoversAsync();
    }
}
