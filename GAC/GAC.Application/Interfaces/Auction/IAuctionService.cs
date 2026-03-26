using GAC.Application.Services.Auction.Dtos;
using GAC.Common.Responce;

namespace GAC.Application.Interfaces.Auction
{
    public interface IAuctionService
    {
        Task<Response<GetAuctionDto>> CreateAuctionAsync(CreateAuctionDto dto);
        Task<Response<GetAuctionDto>> EndAuctionAsync(long auctionId);
        Task<Response<GetAuctionDto>> PlaceBidAsync(PlaceBidDto dto);
        Task<Response<GetAuctionDto>> GetByIdAsync(long id);
        Task<Response<List<GetAuctionDto>>> GetAllActiveAuctionsAsync();
        Task<Response<List<GetAuctionDto>>> GetCompletedAuctionsAsync();
        Task<Response<List<GetBidDto>>> GetBidHistoryAsync(long auctionId);
        Task<Response<List<MyBidDto>>> GetMyActiveBidsAsync();
        Task<Response<List<MyWinDto>>> GetMyWonAuctionsAsync();
    }
}
