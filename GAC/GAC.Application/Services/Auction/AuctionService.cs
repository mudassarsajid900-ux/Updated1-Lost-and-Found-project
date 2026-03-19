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

            var entity = new AuctionRecord
            {
                FoundItemId = dto.FoundItemId,
                HighestBid = 0,
                IsActive = true,
                CreatedBy = _userData.UserId
            };

            await _auctionRepository.AddAsync(entity);

            // Update Item Status so it can't be used for replacement or matched anymore
            item.Status = ItemStatus.Auction;
            await _itemRepository.UpdateAsync(item);

            var result = _mapper.Map<GetAuctionDto>(entity);
            return Response<GetAuctionDto>.SetSuccessResponse(result, "Auction created successfully", StatusCodes.Status201Created);
        }

        public async Task<Response<GetAuctionDto>> PlaceBidAsync(PlaceBidDto dto)
        {
            var entity = await _auctionRepository.GetByIdAsync(dto.AuctionId);
            if (entity == null)
                return Response<GetAuctionDto>.NotFoundResponse();

            if (!entity.IsActive)
                return Response<GetAuctionDto>.SetCustomErrorResponse("Auction is not active", StatusCodes.Status400BadRequest);

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
                .Where(x => x.IsActive)
                .ToListAsync();

            var result = _mapper.Map<List<GetAuctionDto>>(auctions);
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
                    TimeLeft = "Active" // Or format a countdown if you have and EndDate (not in schema yet)
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
