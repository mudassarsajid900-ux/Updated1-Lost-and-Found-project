using GAC.Application.Services.ClaimRequests.Dtos;
using GAC.Common.Responce;

namespace GAC.Application.Interfaces.ClaimRequests
{
    public interface IClaimService
    {
        Task<Response<GetClaimDto>> SubmitClaimAsync(CreateClaimDto dto);
        Task<Response<GetClaimDto>> UpdateClaimStatusAsync(UpdateClaimStatusDto dto);
        Task<Response<GetClaimDto>> GetByIdAsync(long id);
        Task<Response<List<GetClaimDto>>> GetMyClaimsAsync();
        Task<Response<List<GetClaimDto>>> GetAllClaimsAsync();
    }
}
