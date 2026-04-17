// ========================================== //
// SECTION: ASSET DISPOSITION SERVICES
// DESCRIPTION: Manages the legal release and verification of physical items.
// ========================================== //
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
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GAC.Application.Services.Handover
{
    /// <summary>
    /// The HandoverService is responsible for the 'Proof of Delivery' stage.
    /// It captures biometric/identity evidence (CNIC and Person Photos) to ensure
    /// absolute accountability when an item leaves the campus custody.
    /// </summary>
    public class HandoverService : IHandoverService
    {
        private readonly IGenericRepository<ItemsHandOverRecord> _handoverRepository;
        private readonly IGenericRepository<Items> _itemRepository;
        private readonly IGenericRepository<ClaimRequest> _claimRepository;
        private readonly IGenericRepository<ReplacementRecord> _replacementRepository;
        private readonly IGenericRepository<AuctionRecord> _auctionRepository;
        private readonly IGenericRepository<ItemMatch> _itemMatchRepository;
        private readonly IMapper _mapper;
        private readonly UserData _userData;
        private readonly IWebHostEnvironment _environment;

        public HandoverService(
            IGenericRepository<ItemsHandOverRecord> handoverRepository,
            IGenericRepository<Items> itemRepository,
            IGenericRepository<ClaimRequest> claimRepository,
            IGenericRepository<ReplacementRecord> replacementRepository,
            IGenericRepository<AuctionRecord> auctionRepository,
            IGenericRepository<ItemMatch> itemMatchRepository,
            IMapper mapper,
            UserData userData,
            IWebHostEnvironment environment)
        {
            _handoverRepository = handoverRepository;
            _itemRepository = itemRepository;
            _claimRepository = claimRepository;
            _replacementRepository = replacementRepository;
            _auctionRepository = auctionRepository;
            _itemMatchRepository = itemMatchRepository;
            _mapper = mapper;
            _userData = userData;
            _environment = environment;
        }

        /// <summary>
        /// Records a physical handover event and finalizes the related item lifecycle.
        /// This is the final state transition for any asset in the system.
        /// </summary>
        /// <param name="dto">Handover details including recipient identity and evidence photos.</param>
        public async Task<Response<GetHandoverDto>> CreateHandoverAsync(CreateHandoverDto dto)
        {
            // 1. Initial State Verification
            var item = await _itemRepository.GetByIdAsync(dto.ItemId);
            if (item == null)
                return Response<GetHandoverDto>.SetCustomErrorResponse("Fulfillment Error: Target asset not found.", StatusCodes.Status404NotFound);

            var entity = _mapper.Map<ItemsHandOverRecord>(dto);
            entity.CreatedBy = _userData.UserId;
            entity.CreatedOn = DateTime.UtcNow;

            // 2. Identity Evidence Capture (Secure Uploads)
            if (dto.CnicPhoto != null)
                entity.CnicImagePath = await SavePhoto(dto.CnicPhoto);

            if (dto.PersonPhoto != null)
                entity.PersonImagePath = await SavePhoto(dto.PersonPhoto);

            await _handoverRepository.AddAsync(entity);

            // 3. Lifecycle Finalization (State Machine Transitions)
            switch (dto.HandoverType)
            {
                case HandoverType.FoundItemToAdmin:
                    // Stage: Initial Receipt (Student -> Office)
                    item.Status = ItemStatus.Found; 
                    item.IsVerifiedByAdmin = true; 
                    item.VerifiedDate = DateTime.UtcNow; 
                    break;

                case HandoverType.AdminToClaimant:
                    // Stage: Owner Retrieval (Office -> User)
                    item.Status = ItemStatus.Handover;
                    if (dto.ClaimRequestId.HasValue)
                    {
                        var claim = await _claimRepository.AsQueryable()
                            .Include(c => c.LostItem)
                            .FirstOrDefaultAsync(c => c.Id == dto.ClaimRequestId.Value);

                        if (claim != null)
                        {
                            claim.Status = ClaimStatus.HandedOver;
                            if (claim.LostItem != null)
                            {
                                claim.LostItem.Status = ItemStatus.Handover;
                                await _itemRepository.UpdateAsync(claim.LostItem);
                            }

                            // Resolution: Archive the forensic match as successfully resolved
                            var match = await _itemMatchRepository.AsQueryable()
                                .FirstOrDefaultAsync(m => ((m.LostItemId == claim.LostItemId && m.FoundItemId == claim.FoundItemId) || (m.LostItemId == claim.FoundItemId && m.FoundItemId == claim.LostItemId)) && !m.IsMatchResolved);
                            
                            if (match != null)
                            {
                                match.IsMatchResolved = true;
                                await _itemMatchRepository.UpdateAsync(match);
                            }

                            await _claimRepository.UpdateAsync(claim);
                        }
                    }
                    break;

                case HandoverType.AdminToReplacementUser:
                    // Stage: Replacement Distribution (Office -> User)
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
                    // Stage: Auction Liquidation (Office -> Winner)
                    item.Status = ItemStatus.AuctionHandover;
                    break;
            }

            // Sync final item state
            await _itemRepository.UpdateAsync(item);

            var result = _mapper.Map<GetHandoverDto>(entity);
            return Response<GetHandoverDto>.SetSuccessResponse(result, "Identity verified: Handover record sealed.", StatusCodes.Status201Created);
        }

        /// <summary>
        /// Retrieves the comprehensive audit log of all historical handover events.
        /// </summary>
        public async Task<Response<List<GetHandoverDto>>> GetAllHandoversAsync()
        {
            var handovers = await _handoverRepository.AsQueryable()
                .Include(x => x.Item).ThenInclude(i => i.ItemType)
                .Include(x => x.Item).ThenInclude(i => i.Attributes)
                .OrderByDescending(x => x.CreatedOn)
                .ToListAsync();

            var result = handovers.Select(x => new GetHandoverDto
            {
                Id = x.Id,
                ItemId = x.ItemId,
                ItemTitle = x.Item?.ItemType?.Name ?? $"Asset #{x.ItemId}",
                ItemCategory = x.Item?.ItemType?.Name ?? "General",
                ReceiverName = x.ReceiverName,
                ReceiverCnic = x.ReceiverCnic,
                ReceiverPhone = x.ReceiverPhone,
                CnicImagePath = x.CnicImagePath,
                PersonImagePath = x.PersonImagePath,
                AdminNotes = x.AdminNotes,
                HandoverType = x.HandoverType,
                CreatedOn = x.CreatedOn,
                Attributes = x.Item?.Attributes.Select(a => new GAC.Application.Services.Item.Dtos.GetItemAttributes
                {
                    Id = a.Id, FieldName = a.FieldName, FieldValue = a.FieldValue
                }).ToList() ?? new()
            }).ToList();

            return Response<List<GetHandoverDto>>.SetSuccessResponse(result);
        }

        /// <summary>
        /// Retrieves a specific handover log by its unique identifier.
        /// </summary>
        public async Task<Response<GetHandoverDto>> GetByIdAsync(long id)
        {
            var entity = await _handoverRepository.AsQueryable()
                .Include(x => x.Item).ThenInclude(i => i.ItemType)
                .Include(x => x.Item).ThenInclude(i => i.Attributes)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null) return Response<GetHandoverDto>.NotFoundResponse();

            var result = _mapper.Map<GetHandoverDto>(entity);
            result.ItemTitle = entity.Item?.ItemType?.Name ?? $"Asset #{entity.ItemId}";

            return Response<GetHandoverDto>.SetSuccessResponse(result);
        }

        /// <summary>
        /// The 'Waiting Room' aggregation service.
        /// Scans all system states to identify assets physically ready for movement.
        /// Grouped by: Direct Receipts, Claims, Replacements, and Auctions.
        /// </summary>
        public async Task<Response<List<PendingHandoverDto>>> GetPendingHandoversAsync()
        {
            var result = new List<PendingHandoverDto>();

            // 1. Queue: New student-reported Found items (Target: Student -> Office)
            var foundItems = await _itemRepository.AsQueryable()
                .Include(x => x.ItemType).Include(x => x.Attributes).Include(x => x.Location).Include(x => x.CreatedByUser)
                .Where(x => x.ReportType == ReportType.Found && x.Status == ItemStatus.Found).ToListAsync();
            
            var existingReceipts = await _handoverRepository.AsQueryable()
                .Where(x => x.HandoverType == HandoverType.FoundItemToAdmin).Select(x => x.ItemId).ToListAsync();

            foreach (var item in foundItems.Where(i => !existingReceipts.Contains(i.Id)))
            {
                result.Add(new PendingHandoverDto
                {
                    ItemId = item.Id, ItemTitle = item.ItemType.Name, ItemImageUrl = item.ImageUrl,
                    HandoverType = HandoverType.FoundItemToAdmin,
                    TargetPersonName = $"{item.CreatedByUser?.FirstName} {item.CreatedByUser?.LastName}",
                    TargetPersonEmail = item.CreatedByUser?.Email, TargetPersonPhone = item.CreatedByUser?.PhoneNumber ?? "",
                    ItemLocation = item.Location?.Name,
                    Attributes = item.Attributes.Select(a => new GAC.Application.Services.Item.Dtos.GetItemAttributes { Id = a.Id, FieldName = a.FieldName, FieldValue = a.FieldValue }).ToList()
                });
            }

            // 2. Queue: Verified Claim requests (Target: Office -> Owner)
            var claims = await _claimRepository.AsQueryable()
                .Include(x => x.FoundItem).ThenInclude(i => i.ItemType).Include(x => x.FoundItem).ThenInclude(i => i.Attributes)
                .Include(x => x.FoundItem).ThenInclude(i => i.Location).Include(x => x.CreatedByUser)
                .Where(x => x.Status == ClaimStatus.VerificationSucceeded).ToListAsync();

            foreach (var claim in claims)
            {
                result.Add(new PendingHandoverDto
                {
                    ItemId = claim.FoundItemId, ItemTitle = claim.FoundItem.ItemType.Name, ItemImageUrl = claim.FoundItem.ImageUrl,
                    HandoverType = HandoverType.AdminToClaimant, ClaimRequestId = claim.Id,
                    TargetPersonName = $"{claim.CreatedByUser?.FirstName} {claim.CreatedByUser?.LastName}",
                    TargetPersonEmail = claim.CreatedByUser?.Email, TargetPersonPhone = claim.CreatedByUser?.PhoneNumber ?? "",
                    ItemLocation = claim.FoundItem.Location?.Name,
                    Attributes = claim.FoundItem.Attributes.Select(a => new GAC.Application.Services.Item.Dtos.GetItemAttributes { Id = a.Id, FieldName = a.FieldName, FieldValue = a.FieldValue }).ToList()
                });
            }

            // 3. Queue: Approved Replacement allocations (Target: Office -> User)
            var replacements = await _replacementRepository.AsQueryable()
                .Include(x => x.FoundItem).ThenInclude(i => i.ItemType).Include(x => x.FoundItem).ThenInclude(i => i.Attributes)
                .Include(x => x.FoundItem).ThenInclude(i => i.Location).Include(x => x.CreatedByUser)
                .Where(x => x.Status == ReplacementStatus.Approved).ToListAsync();

            foreach (var rep in replacements)
            {
                result.Add(new PendingHandoverDto
                {
                    ItemId = rep.FoundItemId ?? 0, ItemTitle = rep.FoundItem?.ItemType.Name ?? "Allocation", ItemImageUrl = rep.FoundItem?.ImageUrl,
                    HandoverType = HandoverType.AdminToReplacementUser, ReplacementRecordId = rep.Id,
                    TargetPersonName = $"{rep.CreatedByUser?.FirstName} {rep.CreatedByUser?.LastName}",
                    TargetPersonEmail = rep.CreatedByUser?.Email, TargetPersonPhone = rep.CreatedByUser?.PhoneNumber ?? "",
                    ItemLocation = rep.FoundItem?.Location?.Name,
                    Attributes = rep.FoundItem?.Attributes.Select(a => new GAC.Application.Services.Item.Dtos.GetItemAttributes { Id = a.Id, FieldName = a.FieldName, FieldValue = a.FieldValue }).ToList() ?? new()
                });
            }

            // 4. Queue: Closed Auctions awaiting collection (Target: Office -> Winner)
            var auctions = await _auctionRepository.AsQueryable()
                .Include(x => x.FoundItem).ThenInclude(i => i.ItemType).Include(x => x.FoundItem).ThenInclude(i => i.Attributes)
                .Include(x => x.FoundItem).ThenInclude(i => i.Location).Include(x => x.HighestBidder)
                .Where(x => !x.IsActive && x.HighestBidderId > 0).ToListAsync();

            var handedOverAuctions = await _handoverRepository.AsQueryable()
                .Where(x => x.HandoverType == HandoverType.AdminToAuctionWinner).Select(x => x.AuctionRecordId).ToListAsync();

            foreach (var auction in auctions.Where(a => !handedOverAuctions.Contains(a.Id)))
            {
                result.Add(new PendingHandoverDto
                {
                    ItemId = auction.FoundItemId, ItemTitle = auction.FoundItem.ItemType.Name, ItemImageUrl = auction.FoundItem.ImageUrl,
                    HandoverType = HandoverType.AdminToAuctionWinner, AuctionRecordId = auction.Id,
                    TargetPersonName = $"{auction.HighestBidder?.FirstName} {auction.HighestBidder?.LastName}",
                    TargetPersonEmail = auction.HighestBidder?.Email, TargetPersonPhone = auction.HighestBidder?.PhoneNumber ?? "",
                    ItemLocation = auction.FoundItem.Location?.Name,
                    Attributes = auction.FoundItem.Attributes.Select(a => new GAC.Application.Services.Item.Dtos.GetItemAttributes { Id = a.Id, FieldName = a.FieldName, FieldValue = a.FieldValue }).ToList()
                });
            }

            return Response<List<PendingHandoverDto>>.SetSuccessResponse(result);
        }

        /// <summary>
        /// Permanently archives identity evidence photos.
        /// Includes standard file type and size constraints.
        /// </summary>
        private async Task<string> SavePhoto(IFormFile photo)
        {
            var allowed = new[] { ".jpg", ".jpeg", ".png" };
            var ext = Path.GetExtension(photo.FileName)?.ToLower();
            if (string.IsNullOrEmpty(ext) || !allowed.Contains(ext))
                throw new InvalidOperationException("Evidence Error: Unsupported photo format.");

            if (photo.Length > 2 * 1024 * 1024) throw new InvalidOperationException("Evidence Error: Photo exceeds 2MB limit.");

            var uploadsRoot = Path.Combine(_environment.WebRootPath, "uploads", "handovers");
            if (!Directory.Exists(uploadsRoot)) Directory.CreateDirectory(uploadsRoot);

            var fileName = $"{Guid.NewGuid()}{ext}";
            var filePath = Path.Combine(uploadsRoot, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create)) { await photo.CopyToAsync(stream); }

            return $"/uploads/handovers/{fileName}";
        }
    }
}
