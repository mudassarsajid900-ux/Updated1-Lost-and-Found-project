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

namespace GAC.Application.Services.Auction
{
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

        public async Task<Response<GetAuctionDto>> CreateAuctionAsync(CreateAuctionDto dto)
        {
            var item = await _itemRepository.GetByIdAsync(dto.FoundItemId);
            if (item == null)
                return Response<GetAuctionDto>.SetCustomErrorResponse("Item not found", StatusCodes.Status404NotFound);

            // BUG FIX: Prevent duplicate auctions for the same item
            var existingActiveAuction = await _auctionRepository.AsQueryable()
                .FirstOrDefaultAsync(x => x.FoundItemId == dto.FoundItemId && x.IsActive);
            if (existingActiveAuction != null)
                return Response<GetAuctionDto>.SetCustomErrorResponse("An active auction already exists for this item.", StatusCodes.Status409Conflict);

            var entity = new AuctionRecord
            {
                FoundItemId = dto.FoundItemId,
                HighestBid = dto.StartingPrice,
                IsActive = true,
                CreatedBy = _userData.UserId,
                HighestBidderId = null,
                EndDate = DateTime.UtcNow.AddHours(dto.DurationHours)
            };

            await _auctionRepository.AddAsync(entity);

            item.Status = ItemStatus.Auction;
            await _itemRepository.UpdateAsync(item);

            var result = _mapper.Map<GetAuctionDto>(entity);
            return Response<GetAuctionDto>.SetSuccessResponse(result, "Auction created successfully", StatusCodes.Status201Created);
        }

        public async Task<Response<GetAuctionDto>> EndAuctionAsync(long auctionId)
        {
            var entity = await _auctionRepository.AsQueryable()
                .Include(x => x.FoundItem)
                .ThenInclude(i => i.ItemType)
                .FirstOrDefaultAsync(x => x.Id == auctionId);
                
            if (entity == null)
                return Response<GetAuctionDto>.NotFoundResponse();

            if (!entity.IsActive)
                return Response<GetAuctionDto>.SetCustomErrorResponse("Auction is already ended", StatusCodes.Status400BadRequest);

            entity.IsActive = false;
            if (entity.FoundItem != null)
            {
                entity.FoundItem.Status = ItemStatus.AuctionHandover;
                entity.FoundItem.LastModifiedOn = DateTime.UtcNow;
            }
            await _auctionRepository.UpdateAsync(entity);

            var result = _mapper.Map<GetAuctionDto>(entity);
            return Response<GetAuctionDto>.SetSuccessResponse(result, "Auction ended successfully");
        }

        public async Task<Response<GetAuctionDto>> PlaceBidAsync(PlaceBidDto dto)
        {
            var entity = await _auctionRepository.GetByIdAsync(dto.AuctionId);
            if (entity == null)
                return Response<GetAuctionDto>.NotFoundResponse();

            if (!entity.IsActive)
                return Response<GetAuctionDto>.SetCustomErrorResponse("Auction is not active", StatusCodes.Status400BadRequest);

            if (DateTime.UtcNow > entity.EndDate)
                return Response<GetAuctionDto>.SetCustomErrorResponse("Auction has already ended", StatusCodes.Status400BadRequest);

            if (dto.BidAmount <= entity.HighestBid)
                return Response<GetAuctionDto>.SetCustomErrorResponse("Bid must be higher than current highest bid", StatusCodes.Status400BadRequest);

            // 1. Update Auction Record
            entity.HighestBid = dto.BidAmount;
            entity.HighestBidderId = _userData.UserId;
            await _auctionRepository.UpdateAsync(entity);

            // 2. Save to Bid History
            var bid = new Bid
            {
                FoundItemId = entity.FoundItemId,
                BidderId = _userData.UserId,
                BidAmount = dto.BidAmount,
                CreatedBy = _userData.UserId
            };
            await _bidRepository.AddAsync(bid);

            var result = _mapper.Map<GetAuctionDto>(entity);
            return Response<GetAuctionDto>.SetSuccessResponse(result, "Bid placed successfully");
        }

        public async Task<Response<GetAuctionDto>> GetByIdAsync(long id)
        {
            var entity = await _auctionRepository.AsQueryable()
                .Include(x => x.FoundItem)
                .ThenInclude(i => i.ItemType)
                .Include(x => x.FoundItem)
                .ThenInclude(i => i.Attributes)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null)
                return Response<GetAuctionDto>.NotFoundResponse();

            var result = _mapper.Map<GetAuctionDto>(entity);
            return Response<GetAuctionDto>.SetSuccessResponse(result);
        }

        public async Task<Response<List<GetAuctionDto>>> GetAllActiveAuctionsAsync()
        {
            var auctions = await _auctionRepository.AsQueryable()
                .Include(x => x.FoundItem)
                .ThenInclude(i => i.ItemType)
                .Include(x => x.FoundItem)
                .ThenInclude(i => i.Attributes)
                .Include(x => x.HighestBidder)  // BUG FIX: Was missing — bidder name was always null
                .Where(x => x.IsActive)
                .ToListAsync();

            // BUG FIX: Manually set HighestBidderName (same pattern as GetCompletedAuctionsAsync)
            var result = auctions.Select(x => {
                var dto = _mapper.Map<GetAuctionDto>(x);
                dto.HighestBidderName = x.HighestBidder != null
                    ? (x.HighestBidder.FirstName + " " + x.HighestBidder.LastName)
                    : "No Bids";
                return dto;
            }).ToList();

            return Response<List<GetAuctionDto>>.SetSuccessResponse(result);
        }

        public async Task<Response<List<GetAuctionDto>>> GetCompletedAuctionsAsync()
        {
            var auctions = await _auctionRepository.AsQueryable()
                .Include(x => x.FoundItem)
                .ThenInclude(i => i.ItemType)
                .Include(x => x.HighestBidder)
                .Where(x => !x.IsActive)
                .ToListAsync();

            var result = auctions.Select(x => {
                var dto = _mapper.Map<GetAuctionDto>(x);
                dto.HighestBidderName = x.HighestBidder != null ? (x.HighestBidder.FirstName + " " + x.HighestBidder.LastName) : "No Bidder";
                return dto;
            }).ToList();

            return Response<List<GetAuctionDto>>.SetSuccessResponse(result);
        }
        public async Task<Response<List<GetBidDto>>> GetBidHistoryAsync(long auctionId)
        {
            var auction = await _auctionRepository.GetByIdAsync(auctionId);
            if (auction == null)
                return Response<List<GetBidDto>>.NotFoundResponse();

            var bids = await _bidRepository.AsQueryable()
                .Include(x => x.Bidder)
                .Where(x => x.FoundItemId == auction.FoundItemId)
                .OrderByDescending(x => x.CreatedOn)
                .ToListAsync();

            var result = _mapper.Map<List<GetBidDto>>(bids);
            return Response<List<GetBidDto>>.SetSuccessResponse(result);
        }

        public async Task<Response<List<MyBidDto>>> GetMyActiveBidsAsync()
        {
            var userId = _userData.UserId;

            // 1. Find all active auctions the user has bid on
            var activeUserBids = await _bidRepository.AsQueryable()
                .Include(b => b.FoundItem)
                    .ThenInclude(i => i.ItemType)
                .Join(_auctionRepository.AsQueryable().Where(ar => ar.IsActive),
                    bid => bid.FoundItemId,
                    auction => auction.FoundItemId,
                    (bid, auction) => new { bid, auction })
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

        public async Task<Response<List<MyWinDto>>> GetMyWonAuctionsAsync()
        {
            var userId = _userData.UserId;

            // 1. Find all ended auctions where user is the highest bidder
            var wonAuctions = await _auctionRepository.AsQueryable()
                .Include(ar => ar.FoundItem)
                    .ThenInclude(i => i.ItemType)
                .Where(ar => !ar.IsActive && ar.HighestBidderId == userId)
                .Select(ar => new MyWinDto
                {
                    AuctionId = ar.Id,
                    ItemTitle = ar.FoundItem.ItemType.Name,
                    ItemImageUrl = ar.FoundItem.ImageUrl,
                    WinningBid = ar.HighestBid,
                    EndDate = ar.LastModifiedOn,
                    OrderNumber = "LF-" + ar.Id.ToString().PadLeft(4, '0')
                })
                .ToListAsync();

            return Response<List<MyWinDto>>.SetSuccessResponse(wonAuctions);
        }
    }
}
