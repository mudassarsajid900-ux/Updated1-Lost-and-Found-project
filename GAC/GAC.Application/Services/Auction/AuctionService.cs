// ========================================== //
// SECTION: AUCTION OPERATIONS SERVICES
// DESCRIPTION: Liquidation of unclaimed verified found assets through internal bidding.
// ========================================== //
using AutoMapper;
using GAC.Application.Helper;
using GAC.Application.Interfaces.Auction;
using GAC.Application.Interfaces.Shared;
using GAC.Application.Services.Auction.Dtos;
using GAC.Common.Responce;
using GAC.Core.Entities.Auction;
using GAC.Core.Entities.Item;
using GAC.Core.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GAC.Application.Services.Auction
{
    /// <summary>
    /// The AuctionService manages the 'End of Life' cycle for unclaimed campus assets.
    /// It facilitates a competitive bidding environment for verified found items,
    /// ensuring fair redistribution of property while maintaining a complete audit trail of offers.
    /// </summary>
    public class AuctionService : IAuctionService
    {
        private readonly IGenericRepository<AuctionRecord> _auctionRepository;
        private readonly IGenericRepository<Bid> _bidRepository;
        private readonly IGenericRepository<Items> _itemRepository;
        private readonly IMapper _mapper;
        private readonly UserData _userData;

        public AuctionService(
            IGenericRepository<AuctionRecord> auctionRepository,
            IGenericRepository<Bid> bidRepository,
            IGenericRepository<Items> itemRepository,
            IMapper mapper,
            UserData userData)
        {
            _auctionRepository = auctionRepository;
            _bidRepository = bidRepository;
            _itemRepository = itemRepository;
            _mapper = mapper;
            _userData = userData;
        }

        /// <summary>
        /// Initiates a new auction for an unclaimed found asset.
        /// Enforces concurrency checks to prevent duplicate auction events for a single item.
        /// </summary>
        /// <param name="dto">Auction configuration including starting price and duration.</param>
        public async Task<Response<GetAuctionDto>> CreateAuctionAsync(CreateAuctionDto dto)
        {
            var item = await _itemRepository.GetByIdAsync(dto.FoundItemId);
            if (item == null)
                return Response<GetAuctionDto>.SetCustomErrorResponse("Validation Error: Underlying asset not found.", StatusCodes.Status404NotFound);

            // Constraint: Prevent overlapping auction events for the same unique asset
            var existingActiveAuction = await _auctionRepository.AsQueryable()
                .FirstOrDefaultAsync(x => x.FoundItemId == dto.FoundItemId && x.IsActive);
            
            if (existingActiveAuction != null)
                return Response<GetAuctionDto>.SetCustomErrorResponse("Conflict: Asset is already involved in an active auction event.", StatusCodes.Status409Conflict);

            var entity = new AuctionRecord
            {
                FoundItemId = dto.FoundItemId,
                HighestBid = dto.StartingPrice,
                IsActive = true,
                CreatedBy = _userData.UserId,
                CreatedOn = DateTime.UtcNow,
                HighestBidderId = null,
                EndDate = DateTime.UtcNow.AddHours(dto.DurationHours)
            };

            await _auctionRepository.AddAsync(entity);

            // Sync: Transition asset status to 'Auction' to hide from public found list and matching logic
            item.Status = ItemStatus.Auction;
            item.LastModifiedOn = DateTime.UtcNow;
            await _itemRepository.UpdateAsync(item);

            var result = _mapper.Map<GetAuctionDto>(entity);
            return Response<GetAuctionDto>.SetSuccessResponse(result, "Success: Asset is now live in the auction pool.", StatusCodes.Status201Created);
        }

        /// <summary>
        /// Forcefully or naturally concludes an auction event.
        /// Transitions the item to the final handover staging area for the winner.
        /// </summary>
        public async Task<Response<GetAuctionDto>> EndAuctionAsync(long auctionId)
        {
            var entity = await _auctionRepository.AsQueryable()
                .Include(x => x.FoundItem).ThenInclude(i => i.ItemType)
                .FirstOrDefaultAsync(x => x.Id == auctionId);
                
            if (entity == null) return Response<GetAuctionDto>.NotFoundResponse();

            if (!entity.IsActive)
                return Response<GetAuctionDto>.SetCustomErrorResponse("Lifecycle Error: Auction has already been finalized.", StatusCodes.Status400BadRequest);

            // Finalize State
            entity.IsActive = false;
            entity.LastModifiedOn = DateTime.UtcNow;

            if (entity.FoundItem != null)
            {
                entity.FoundItem.Status = ItemStatus.AuctionHandover;
                entity.FoundItem.LastModifiedOn = DateTime.UtcNow;
            }

            await _auctionRepository.UpdateAsync(entity);

            var result = _mapper.Map<GetAuctionDto>(entity);
            return Response<GetAuctionDto>.SetSuccessResponse(result, "Success: Auction finalized. Asset staged for handover.");
        }

        /// <summary>
        /// Process logic for placing a new competitive bid.
        /// Implements 'High-Water Mark' validation to ensure bids strictly increase in value.
        /// </summary>
        public async Task<Response<GetAuctionDto>> PlaceBidAsync(PlaceBidDto dto)
        {
            var entity = await _auctionRepository.GetByIdAsync(dto.AuctionId);
            if (entity == null) return Response<GetAuctionDto>.NotFoundResponse();

            // Guard: Temporal and Logic validity checks
            if (!entity.IsActive)
                return Response<GetAuctionDto>.SetCustomErrorResponse("Bid Rejected: Auction event is closed.", StatusCodes.Status400BadRequest);

            if (DateTime.UtcNow > entity.EndDate)
                return Response<GetAuctionDto>.SetCustomErrorResponse("Bid Rejected: Auction timeframe has expired.", StatusCodes.Status400BadRequest);

            if (dto.BidAmount <= entity.HighestBid)
                return Response<GetAuctionDto>.SetCustomErrorResponse("Bid Rejected: Offer must exceed the current highest bid.", StatusCodes.Status400BadRequest);

            // Execution: Update Current Standing
            entity.HighestBid = dto.BidAmount;
            entity.HighestBidderId = _userData.UserId;
            entity.LastModifiedOn = DateTime.UtcNow;
            await _auctionRepository.UpdateAsync(entity);

            // Persistence: Append to forensic history of all offers
            var bid = new Bid
            {
                FoundItemId = entity.FoundItemId,
                BidderId = _userData.UserId,
                BidAmount = dto.BidAmount,
                CreatedBy = _userData.UserId,
                CreatedOn = DateTime.UtcNow
            };
            await _bidRepository.AddAsync(bid);

            var result = _mapper.Map<GetAuctionDto>(entity);
            return Response<GetAuctionDto>.SetSuccessResponse(result, "Success: Your bid is currently the highest.");
        }

        public async Task<Response<GetAuctionDto>> GetByIdAsync(long id)
        {
            var entity = await _auctionRepository.AsQueryable()
                .Include(x => x.FoundItem).ThenInclude(i => i.ItemType)
                .Include(x => x.FoundItem).ThenInclude(i => i.Attributes)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null) return Response<GetAuctionDto>.NotFoundResponse();

            return Response<GetAuctionDto>.SetSuccessResponse(_mapper.Map<GetAuctionDto>(entity));
        }

        /// <summary>
        /// Retrieves all auctions currently accepting new bids.
        /// Populates human-readable bidder names for admin/public transparency.
        /// </summary>
        public async Task<Response<List<GetAuctionDto>>> GetAllActiveAuctionsAsync()
        {
            var auctions = await _auctionRepository.AsQueryable()
                .Include(x => x.FoundItem).ThenInclude(i => i.ItemType)
                .Include(x => x.FoundItem).ThenInclude(i => i.Attributes)
                .Include(x => x.HighestBidder)
                .Where(x => x.IsActive)
                .ToListAsync();

            var result = auctions.Select(x => {
                var dto = _mapper.Map<GetAuctionDto>(x);
                dto.HighestBidderName = x.HighestBidder != null
                    ? $"{x.HighestBidder.FirstName} {x.HighestBidder.LastName}"
                    : "Opening Bid";
                return dto;
            }).ToList();

            return Response<List<GetAuctionDto>>.SetSuccessResponse(result);
        }

        /// <summary>
        /// Retrieves history of concluded auctions.
        /// Used for auditing asset redistribution and reporting.
        /// </summary>
        public async Task<Response<List<GetAuctionDto>>> GetCompletedAuctionsAsync()
        {
            var auctions = await _auctionRepository.AsQueryable()
                .Include(x => x.FoundItem).ThenInclude(i => i.ItemType)
                .Include(x => x.HighestBidder)
                .Where(x => !x.IsActive)
                .ToListAsync();

            var result = auctions.Select(x => {
                var dto = _mapper.Map<GetAuctionDto>(x);
                dto.HighestBidderName = x.HighestBidder != null 
                    ? $"{x.HighestBidder.FirstName} {x.HighestBidder.LastName}" 
                    : "No successful bids";
                return dto;
            }).ToList();

            return Response<List<GetAuctionDto>>.SetSuccessResponse(result);
        }

        /// <summary>
        /// Fetches the chronological offer history for a specific auction event.
        /// </summary>
        public async Task<Response<List<GetBidDto>>> GetBidHistoryAsync(long auctionId)
        {
            var auction = await _auctionRepository.GetByIdAsync(auctionId);
            if (auction == null) return Response<List<GetBidDto>>.NotFoundResponse();

            var bids = await _bidRepository.AsQueryable()
                .Include(x => x.Bidder)
                .Where(x => x.FoundItemId == auction.FoundItemId)
                .OrderByDescending(x => x.CreatedOn)
                .ToListAsync();

            return Response<List<GetBidDto>>.SetSuccessResponse(_mapper.Map<List<GetBidDto>>(bids));
        }

        /// <summary>
        /// Student Portal: Retrieves a summary of all active auctions where the user has placed a bid.
        /// Includes a 'Highest Bidder' status indicator for UI awareness.
        /// </summary>
        public async Task<Response<List<MyBidDto>>> GetMyActiveBidsAsync()
        {
            var userId = _userData.UserId;
            if (userId == 0) return Response<List<MyBidDto>>.SetCustomErrorResponse("Unauthorized", 401);

            var activeUserBids = await _bidRepository.AsQueryable()
                .Include(b => b.FoundItem).ThenInclude(i => i.ItemType)
                .Join(_auctionRepository.AsQueryable().Include(ar => ar.FoundItem).Where(ar => ar.IsActive),
                    bid => bid.FoundItemId, auction => auction.FoundItemId, (bid, auction) => new { bid, auction })
                .Where(x => x.bid.BidderId == userId)
                .GroupBy(x => x.auction.Id)
                .Select(g => new MyBidDto
                {
                    AuctionId = g.Key,
                    ItemTitle = g.First().auction.FoundItem.ItemType.Name,
                    ItemImageUrl = g.First().auction.FoundItem.ImageUrl,
                    MyHighestBid = g.Max(x => x.bid.BidAmount),
                    CurrentHighestBid = g.First().auction.HighestBid,
                    IsHighestBidder = (g.First().auction.HighestBidderId == userId),
                    EndDate = g.First().auction.EndDate
                })
                .ToListAsync();

            return Response<List<MyBidDto>>.SetSuccessResponse(activeUserBids);
        }

        /// <summary>
        /// Student Portal: Retrieves a history of auctions successfully won by the user.
        /// Formats an internal 'Order Number' for collection reference.
        /// </summary>
        public async Task<Response<List<MyWinDto>>> GetMyWonAuctionsAsync()
        {
            var userId = _userData.UserId;
            if (userId == 0) return Response<List<MyWinDto>>.SetCustomErrorResponse("Unauthorized", 401);

            var wonAuctions = await _auctionRepository.AsQueryable()
                .Include(ar => ar.FoundItem).ThenInclude(i => i.ItemType)
                .Where(ar => !ar.IsActive && ar.HighestBidderId == userId)
                .Select(ar => new MyWinDto
                {
                    AuctionId = ar.Id,
                    ItemTitle = ar.FoundItem.ItemType.Name,
                    ItemImageUrl = ar.FoundItem.ImageUrl,
                    WinningBid = ar.HighestBid,
                    EndDate = ar.LastModifiedOn,
                    OrderNumber = $"GAC-AUC-{ar.Id:D4}"
                })
                .ToListAsync();

            return Response<List<MyWinDto>>.SetSuccessResponse(wonAuctions);
        }
    }
}
