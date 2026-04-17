/**
 * @file AuctionController.cs
 * @description Manages the lifecycle of auctioned items, including creation, 
 * bidding, and completion workflows.
 */
using GAC.Application.Interfaces.Auction;
using GAC.Application.Services.Auction.Dtos;
using GAC.Common.Responce;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GAC.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionController : ControllerBase
    {
        private readonly IAuctionService _auctionService;

        public AuctionController(IAuctionService auctionService)
        {
            _auctionService = auctionService;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("create")]
        public async Task<ActionResult<Response<GetAuctionDto>>> CreateAuction(CreateAuctionDto dto)
        {
            var result = await _auctionService.CreateAuctionAsync(dto);
            return StatusCode(result.StatusCode, result);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("{id}/end")]
        public async Task<ActionResult<Response<GetAuctionDto>>> EndAuction(long id)
        {
            var result = await _auctionService.EndAuctionAsync(id);
            return StatusCode(result.StatusCode, result);
        }

        [HttpPost("place-bid")]
        public async Task<ActionResult<Response<GetAuctionDto>>> PlaceBid(PlaceBidDto dto)
        {
            var result = await _auctionService.PlaceBidAsync(dto);
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Response<GetAuctionDto>>> GetById(long id)
        {
            var result = await _auctionService.GetByIdAsync(id);
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("active")]
        public async Task<ActionResult<Response<List<GetAuctionDto>>>> GetActiveAuctions()
        {
            var result = await _auctionService.GetAllActiveAuctionsAsync();
            return StatusCode(result.StatusCode, result);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("completed")]
        public async Task<ActionResult<Response<List<GetAuctionDto>>>> GetCompletedAuctions()
        {
            var result = await _auctionService.GetCompletedAuctionsAsync();
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("{id}/history")]
        public async Task<ActionResult<Response<List<GetBidDto>>>> GetBidHistory(long id)
        {
            var result = await _auctionService.GetBidHistoryAsync(id);
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("my-bids")]
        public async Task<ActionResult<Response<List<MyBidDto>>>> GetMyBids()
        {
            var result = await _auctionService.GetMyActiveBidsAsync();
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("my-wins")]
        public async Task<ActionResult<Response<List<MyWinDto>>>> GetMyWins()
        {
            var result = await _auctionService.GetMyWonAuctionsAsync();
            return StatusCode(result.StatusCode, result);
        }
    }
}
