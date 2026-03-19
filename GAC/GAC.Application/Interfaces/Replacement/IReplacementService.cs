using GAC.Application.Services.Replacement.Dtos;
using GAC.Common.Responce;

namespace GAC.Application.Interfaces.Replacement
{
    public interface IReplacementService
    {
        Task<Response<GetReplacementDto>> CreateReplacementAsync(CreateReplacementDto dto);
        Task<Response<GetReplacementDto>> GetByIdAsync(long id);
        Task<Response<List<GetReplacementDto>>> GetMyReplacementsAsync();
        Task<Response<List<ReplacementEligibleItemDto>>> GetEligibleItemsAsync();
        
        // Admin Methods
        Task<Response<List<GetReplacementDto>>> GetAllPendingRequestsAsync();
        Task<Response<GetReplacementDto>> ProcessRequestAsync(AdminProcessReplacementDto dto);
        Task<Response<List<long>>> GetSmartMatchSuggestionsAsync(long requestId);
        Task<Response<bool>> UpdateReplacementEligibilityThresholdAsync(int days);
        Task<Response<bool>> UpdateFoundToReplacementThresholdAsync(int days);
        Task<Response<bool>> UpdateReplacementToAuctionThresholdAsync(int days);
        Task<Response<Dictionary<string, int>>> GetAllThresholdsAsync();
    }
}
