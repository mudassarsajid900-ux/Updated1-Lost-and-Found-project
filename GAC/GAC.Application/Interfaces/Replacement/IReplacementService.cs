using GAC.Application.Services.Replacement.Dtos;
using GAC.Common.Responce;

namespace GAC.Application.Interfaces.Replacement
{
    public interface IReplacementService
    {
        Task<Response<GetReplacementDto>> CreateReplacementAsync(CreateReplacementDto dto);
        Task<Response<GetReplacementDto>> GetByIdAsync(long id);
        Task<Response<List<GetReplacementDto>>> GetMyReplacementsAsync();
    }
}
