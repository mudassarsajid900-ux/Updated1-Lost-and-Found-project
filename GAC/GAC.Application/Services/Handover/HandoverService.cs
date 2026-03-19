using AutoMapper;
using GAC.Application.Helper;
using GAC.Application.Interfaces.Handover;
using GAC.Application.Interfaces.Shared;
using GAC.Application.Services.Handover.Dtos;
using GAC.Common.Responce;
using GAC.Core.Entities.Auction;
using GAC.Core.Entities.Claims;
using GAC.Core.Entities.Item;
using GAC.Core.Entities.LostItems;
using GAC.Core.Entities.Replacement;
using GAC.Core.Enums;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace GAC.Application.Services.Handover
{
    public class HandoverService : IHandoverService
    {
        private readonly IGenericRepository<ItemsHandOverRecord> _handoverRepository;
        private readonly IGenericRepository<Items> _itemRepository;
        private readonly IGenericRepository<ClaimRequest> _claimRepository;
        private readonly IGenericRepository<ReplacementRecord> _replacementRepository;
        private readonly IGenericRepository<AuctionRecord> _auctionRepository;
        private readonly IMapper _mapper;
        private readonly UserData _userData;
        private readonly IWebHostEnvironment _environment;

        public HandoverService(
            IGenericRepository<ItemsHandOverRecord> handoverRepository,
            IGenericRepository<Items> itemRepository,
            IGenericRepository<ClaimRequest> claimRepository,
            IGenericRepository<ReplacementRecord> replacementRepository,
            IGenericRepository<AuctionRecord> auctionRepository,
            IMapper mapper,
            UserData userData,
            IWebHostEnvironment environment)
        {
            _handoverRepository = handoverRepository;
            _itemRepository = itemRepository;
            _claimRepository = claimRepository;
            _replacementRepository = replacementRepository;
            _auctionRepository = auctionRepository;
            _mapper = mapper;
            _userData = userData;
            _environment = environment;
        }

        public async Task<Response<GetHandoverDto>> CreateHandoverAsync(CreateHandoverDto dto)
        {
            var item = await _itemRepository.GetByIdAsync(dto.ItemId);
            if (item == null)
                return Response<GetHandoverDto>.SetCustomErrorResponse("Item not found", StatusCodes.Status404NotFound);

            var entity = _mapper.Map<ItemsHandOverRecord>(dto);
            entity.CreatedBy = _userData.UserId;

            if (dto.CnicPhoto != null)
                entity.CnicImagePath = await SavePhoto(dto.CnicPhoto);

            if (dto.PersonPhoto != null)
                entity.PersonImagePath = await SavePhoto(dto.PersonPhoto);

            await _handoverRepository.AddAsync(entity);

            // Update Item Status and Original Records based on Handover Type
            switch (dto.HandoverType)
            {
                case HandoverType.FoundItemToAdmin:
                    item.Status = ItemStatus.Found; 
                    break;
                case HandoverType.AdminToClaimant:
                    item.Status = ItemStatus.Handover;
                    if (dto.ClaimRequestId.HasValue)
                    {
                        var claim = await _claimRepository.GetByIdAsync(dto.ClaimRequestId.Value);
                        if (claim != null)
                        {
                            claim.Status = ClaimStatus.HandedOver;
                            await _claimRepository.UpdateAsync(claim);
                        }
                    }
                    break;
                case HandoverType.AdminToReplacementUser:
                    item.Status = ItemStatus.ReplacementHandover;
                    if (dto.ReplacementRecordId.HasValue)
                    {
                        var rep = await _replacementRepository.GetByIdAsync(dto.ReplacementRecordId.Value);
                        if (rep != null)
                        {
                            rep.Status = ReplacementStatus.Completed;
                            await _replacementRepository.UpdateAsync(rep);
                        }
                    }
                    break;
                case HandoverType.AdminToAuctionWinner:
                    item.Status = ItemStatus.AuctionHandover;
                    break;
            }

            await _itemRepository.UpdateAsync(item);

            var result = _mapper.Map<GetHandoverDto>(entity);
            return Response<GetHandoverDto>.SetSuccessResponse(result, "Handover record created successfully", StatusCodes.Status201Created);
        }

        public async Task<Response<List<GetHandoverDto>>> GetAllHandoversAsync()
        {
            var handovers = await _handoverRepository.AsQueryable()
                .Include(x => x.Item)
                .ThenInclude(i => i.ItemType)
                .OrderByDescending(x => x.CreatedOn)
                .ToListAsync();

            var result = _mapper.Map<List<GetHandoverDto>>(handovers);
            return Response<List<GetHandoverDto>>.SetSuccessResponse(result);
        }

        public async Task<Response<GetHandoverDto>> GetByIdAsync(long id)
        {
            var entity = await _handoverRepository.AsQueryable()
                .Include(x => x.Item)
                .ThenInclude(i => i.ItemType)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null)
                return Response<GetHandoverDto>.NotFoundResponse();

            var result = _mapper.Map<GetHandoverDto>(entity);
            return Response<GetHandoverDto>.SetSuccessResponse(result);
        }

        public async Task<Response<List<PendingHandoverDto>>> GetPendingHandoversAsync()
        {
            var result = new List<PendingHandoverDto>();

            // 1. Found Items newly reported (Student hands over to Admin)
            var foundItems = await _itemRepository.AsQueryable()
                .Include(x => x.ItemType)
                .Include(x => x.CreatedByUser)
                .Where(x => x.ReportType == ReportType.Found && x.Status == ItemStatus.Found)
                .ToListAsync();
            
            var existingHandoverItemIds = await _handoverRepository.AsQueryable()
                .Where(x => x.HandoverType == HandoverType.FoundItemToAdmin)
                .Select(x => x.ItemId)
                .ToListAsync();

            foreach (var item in foundItems.Where(i => !existingHandoverItemIds.Contains(i.Id)))
            {
                result.Add(new PendingHandoverDto
                {
                    ItemId = item.Id,
                    ItemTitle = item.ItemType.Name,
                    ItemImageUrl = item.ImageUrl,
                    HandoverType = HandoverType.FoundItemToAdmin,
                    TargetPersonName = item.CreatedByUser?.FirstName + " " + item.CreatedByUser?.LastName,
                    TargetPersonEmail = item.CreatedByUser?.Email
                });
            }

            // 2. Approved Claims (Admin hands over to Claimant)
            var claims = await _claimRepository.AsQueryable()
                .Include(x => x.FoundItem).ThenInclude(i => i.ItemType)
                .Include(x => x.CreatedByUser)
                .Where(x => x.Status == ClaimStatus.VerificationSucced)
                .ToListAsync();

            foreach (var claim in claims)
            {
                result.Add(new PendingHandoverDto
                {
                    ItemId = claim.FoundItemId,
                    ItemTitle = claim.FoundItem.ItemType.Name,
                    ItemImageUrl = claim.FoundItem.ImageUrl,
                    HandoverType = HandoverType.AdminToClaimant,
                    ClaimRequestId = claim.Id,
                    TargetPersonName = claim.CreatedByUser?.FirstName + " " + claim.CreatedByUser?.LastName,
                    TargetPersonEmail = claim.CreatedByUser?.Email
                });
            }

            // 3. Approved Replacements (Admin hands over to User)
            var replacements = await _replacementRepository.AsQueryable()
                .Include(x => x.FoundItem).ThenInclude(i => i.ItemType)
                .Include(x => x.CreatedByUser)
                .Where(x => x.Status == ReplacementStatus.Approved)
                .ToListAsync();

            foreach (var rep in replacements)
            {
                result.Add(new PendingHandoverDto
                {
                    ItemId = rep.FoundItemId ?? 0,
                    ItemTitle = rep.FoundItem?.ItemType.Name ?? "Replacement Item",
                    ItemImageUrl = rep.FoundItem?.ImageUrl,
                    HandoverType = HandoverType.AdminToReplacementUser,
                    ReplacementRecordId = rep.Id,
                    TargetPersonName = rep.CreatedByUser?.FirstName + " " + rep.CreatedByUser?.LastName,
                    TargetPersonEmail = rep.CreatedByUser?.Email
                });
            }

            // 4. Finished Auctions (Admin hands over to Winner)
            var auctions = await _auctionRepository.AsQueryable()
                .Include(x => x.FoundItem).ThenInclude(i => i.ItemType)
                .Include(x => x.HighestBidder)
                .Where(x => !x.IsActive && x.HighestBidderId > 0)
                .ToListAsync();

            var handedOverAuctionIds = await _handoverRepository.AsQueryable()
                .Where(x => x.HandoverType == HandoverType.AdminToAuctionWinner)
                .Select(x => x.AuctionRecordId)
                .ToListAsync();

            foreach (var auction in auctions.Where(a => !handedOverAuctionIds.Contains(a.Id)))
            {
                result.Add(new PendingHandoverDto
                {
                    ItemId = auction.FoundItemId,
                    ItemTitle = auction.FoundItem.ItemType.Name,
                    ItemImageUrl = auction.FoundItem.ImageUrl,
                    HandoverType = HandoverType.AdminToAuctionWinner,
                    AuctionRecordId = auction.Id,
                    TargetPersonName = auction.HighestBidder?.FirstName + " " + auction.HighestBidder?.LastName,
                    TargetPersonEmail = auction.HighestBidder?.Email
                });
            }

            return Response<List<PendingHandoverDto>>.SetSuccessResponse(result);
        }

        private async Task<string> SavePhoto(IFormFile photo)
        {
            var uploadsRoot = Path.Combine(_environment.WebRootPath, "uploads", "handovers");
            if (!Directory.Exists(uploadsRoot))
            {
                Directory.CreateDirectory(uploadsRoot);
            }

            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(photo.FileName);
            var filePath = Path.Combine(uploadsRoot, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await photo.CopyToAsync(stream);
            }

            return "/uploads/handovers/" + fileName;
        }
    }
}
