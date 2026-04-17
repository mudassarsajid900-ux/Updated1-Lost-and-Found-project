// ========================================== //
// SECTION: ITEM MANAGEMENT SERVICES
// DESCRIPTION: Core business logic for Lost/Found reporting and forensic matching.
// ========================================== //
using AutoMapper;
using GAC.Application.Helper;
using GAC.Application.Interfaces.Item;
using GAC.Application.Interfaces.Shared;
using GAC.Application.Services.Item.Dtos;
using GAC.Common.Responce;
using GAC.Core.Entities.Item;
using GAC.Core.Entities.ItemTypes;
using GAC.Core.Enums;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using GAC.Application.Services.Identity.Dtos.Shared;
using GAC.Application.Interfaces.Shared;

namespace GAC.Application.Services.Item
{
    /// <summary>
    /// The ItemService is the primary engine of the GAC platform. 
    /// It manages the lifecycle of item reports, orchestrates forensic matching, 
    /// and ensures secure data access through identity-based verification.
    /// </summary>
    public class ItemService : IItemService
    {
        private readonly IGenericRepository<Items> _itemRepository;
        private readonly IGenericRepository<ItemAttribute> _attributeRepository;
        private readonly IMapper _mapper;
        private readonly UserData _userData;
        private readonly IWebHostEnvironment _environment;
        private readonly IGenericRepository<ItemMatch> _itemMatchRepository;
        private readonly IGenericRepository<GAC.Core.Entities.Claims.ClaimRequest> _claimRepository;
        private readonly IExceptionLogService _exceptionLogService;
        private readonly ILogger<ItemService> _logger;

        public ItemService(
            IGenericRepository<Items> itemRepository,
            IGenericRepository<ItemAttribute> attributeRepository,
            IMapper mapper,
            UserData userData,
            IWebHostEnvironment environment,
            IGenericRepository<ItemMatch> itemMatchRepository,
            IGenericRepository<GAC.Core.Entities.Claims.ClaimRequest> claimRepository,
            IExceptionLogService exceptionLogService,
            ILogger<ItemService> logger)
        {
            _itemRepository = itemRepository;
            _attributeRepository = attributeRepository;
            _mapper = mapper;
            _userData = userData;
            _environment = environment;
            _itemMatchRepository = itemMatchRepository;
            _claimRepository = claimRepository;
            _exceptionLogService = exceptionLogService;
            _logger = logger;
        }

        /// <summary>
        /// Orchestrates the creation of a new item report.
        /// Automatically differentiates between 'Lost' and 'Found' flows.
        /// </summary>
        /// <param name="dto">Report payload containing metadata, forensic attributes, and optional photo.</param>
        public async Task<Response<GetItemDto>> CreateAsync(CreateItemDto dto)
        {
            // Security: Prevent anonymous submissions through strict identity context validation
            if (_userData.UserId == 0)
            {
                return Response<GetItemDto>.SetCustomErrorResponse("Unauthorized: User identity context is missing.", StatusCodes.Status401Unauthorized);
            }

            // Route execution based on report type (Status 0 = Lost, Status 1 = Found)
            if (dto.Status == 0)
            {
                return await CreateLostItem(dto);
            }
            else 
            {
                // Found Item Workflow:
                // 1. Transform DTO and enforce Found classification
                var entity = _mapper.Map<Items>(dto);
                entity.ReportType = ReportType.Found; 

                // 2. Persist media assets if provided
                if (dto.Photo != null)
                {
                    entity.ImageUrl = await SavePhoto(dto.Photo);
                }
                else
                {
                    entity.ImageUrl = ""; // Database non-null safety fallback
                }

                // 3. Populate audit fields for dynamic forensic attributes
                if (entity.Attributes != null)
                {
                    foreach (var attr in entity.Attributes)
                    {
                        attr.CreatedBy = _userData.UserId;
                        attr.CreatedOn = DateTime.UtcNow;
                    }
                }

                // 4. Persistence Commit
                await _itemRepository.AddAsync(entity);

                // 5. Asynchronous Forensic Trigger: Check if this new found item matches an existing lost report
                _ = Task.Run(async () => {
                    try { await CheckForMatchesAsync(entity); } catch { /* Log failure but don't block response */ }
                });

                var result = await GetByIdAsync(entity.Id);
                return Response<GetItemDto>.SetSuccessResponse(
                    result.Data,
                    "Success: Found report is now live and matching logic is active.",
                    StatusCodes.Status201Created);
            }
        }

        /// <summary>
        /// Specialized workflow for 'Lost' reports with built-in Anti-Spam protection.
        /// </summary>
        private async Task<Response<GetItemDto>> CreateLostItem(CreateItemDto dto)
        {
            // Anti-Spam Control: Limit to 10 reports per user per 24h window
            var oneDayAgo = DateTime.UtcNow.AddDays(-1);
            var existingLostReports = await _itemRepository
                .AsNoTracking()
                .Where(x => x.CreatedBy == _userData.UserId
                         && x.ReportType == ReportType.Lost
                         && x.CreatedOn >= oneDayAgo)
                .CountAsync();

            if (existingLostReports >= 10)
            {
                return Response<GetItemDto>.SetCustomErrorResponse("Daily limit reached: High reporting volume detected. Please try again tomorrow.", StatusCodes.Status400BadRequest);
            }

            var entity = _mapper.Map<Items>(dto);
            entity.ReportType = ReportType.Lost;

            if (dto.Photo != null)
            {
                entity.ImageUrl = await SavePhoto(dto.Photo);
            }
            else
            {
                entity.ImageUrl = ""; 
            }

            if (entity.Attributes != null)
            {
                foreach (var attr in entity.Attributes)
                {
                    attr.CreatedBy = _userData.UserId;
                    attr.CreatedOn = DateTime.UtcNow;
                }
            }

            await _itemRepository.AddAsync(entity);

            // Trigger matching for the new Lost query against current Found inventory
            _ = Task.Run(async () => {
                try { await CheckForMatchesAsync(entity); } catch { }
            });

            var result = await GetByIdAsync(entity.Id);
            return Response<GetItemDto>.SetSuccessResponse(
                result.Data,
                "Success: Lost report registered in the forensic matching queue.",
                StatusCodes.Status201Created);
        }

        /// <summary>
        /// Updates a report using the 'Re-Sync' protocol.
        /// This ensures synchronization even if the Item Category (and thus the attribute schema) has changed.
        /// </summary>
        public async Task<Response<GetItemDto>> UpdateAsync(UpdateItemDto dto)
        {
            var existing = await _itemRepository
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == dto.Id);

            if (existing == null)
                return Response<GetItemDto>.NotFoundResponse();

            // Core Metadata Sync
            existing.EventTime = dto.EventTime;
            existing.LocationId = dto.LocationId;
            existing.ItemTypeId = dto.ItemTypeId;
            existing.Status = dto.Status;
            existing.Attributes = null; // Explicitly detach to prevent EF tracking collisions during sync

            await _itemRepository.UpdateAsync(existing);

            // Forensic Attribute Sync: Wipe old data and insert fresh snapshot
            var oldAttrs = await _attributeRepository
                .AsNoTracking()
                .Where(a => a.LostItemId == dto.Id)
                .ToListAsync();

            if (oldAttrs.Any())
                await _attributeRepository.DeleteListAsync(oldAttrs);

            if (dto.Attributes != null && dto.Attributes.Any())
            {
                var newAttrs = dto.Attributes.Select(a => new ItemAttribute
                {
                    FieldName = a.FieldName,
                    FieldValue = a.FieldValue,
                    LostItemId = existing.Id,
                    CreatedBy = existing.CreatedBy,
                    CreatedOn = DateTime.UtcNow,
                    IsActive = true
                }).ToList();

                await _attributeRepository.AddRangeAsync(newAttrs);
            }

            // Force Re-Match Calculation: Attribute changes may invalidate/create new potential matches
            var updatedEntity = await _itemRepository.AsQueryable()
                .Include(x => x.Attributes)
                .FirstOrDefaultAsync(x => x.Id == existing.Id);
            
            if (updatedEntity != null && (updatedEntity.Status == ItemStatus.Lost || updatedEntity.Status == ItemStatus.Found))
            {
                // Trace: Logging re-match trigger for forensic audit
                await _exceptionLogService.LogAsync(new CreateExceptionLogDto {
                    LogLevel = "INFO",
                    Message = $"Audit: Triggering re-match for Item {updatedEntity.Id} due to attribute synchronization.",
                    RequestUrl = "/Item/update",
                    CreatedAt = DateTime.UtcNow,
                    ApplicationName = "GAC_CORE"
                });

                _ = Task.Run(async () => { try { await CheckForMatchesAsync(updatedEntity); } catch (Exception ex) { 
                    // Fail-safe: Ensure background matching failures are captured in system logs
                    _logger.LogError(ex, "Background Matching Error for Item {Id}", updatedEntity.Id);
                }});
            }

            var updated = await GetByIdAsync(existing.Id);
            return Response<GetItemDto>.SetSuccessResponse(updated.Data, "Report state synchronized successfully.");
        }

        /// <summary>
        /// Retrieves detailed report data including forensic attributes and cross-linked match/claim states.
        /// Implements IDOR (Insecure Direct Object Reference) protection.
        /// </summary>
        public async Task<Response<GetItemDto>> GetByIdAsync(long id)
        {
            var entity = await _itemRepository
                .AsNoTracking()
                .Include(x => x.Attributes)
                .Include(x => x.Location)
                .Include(x => x.ItemType)
                .Include(x => x.CreatedByUser)
                .FirstOrDefaultAsync(x => x.Id == id);
            
            if (entity == null || (entity.Location != null && entity.Location.IsDeleted))
                return Response<GetItemDto>.NotFoundResponse();

            // Security: Restrict detailed view to the owner or an administrator
            if (_userData != null && !_userData.Roles.Contains("Admin") && entity.CreatedBy != _userData.UserId)
            {
                return Response<GetItemDto>.SetCustomErrorResponse("Unauthorized: Detailed forensics are restricted to report owners.", StatusCodes.Status403Forbidden);
            }

            var dto = _mapper.Map<GetItemDto>(entity);

            // Lifecycle State Check: Verify if an active match or claim exists
            var match = await _itemMatchRepository.AsQueryable()
                .FirstOrDefaultAsync(m => (m.LostItemId == id || m.FoundItemId == id) && !m.IsMatchResolved);
            
            if (match != null)
            {
                dto.HasPotentialMatch = true;
                dto.MatchFoundItemId = match.LostItemId == id ? match.FoundItemId : match.LostItemId;
                
                var matched = await _itemRepository.AsQueryable().Include(x => x.ItemType).Include(x => x.CreatedByUser).FirstOrDefaultAsync(x => x.Id == dto.MatchFoundItemId);
                if (matched != null)
                {
                    dto.MatchItemType = matched.ItemType?.Name;
                    dto.MatchReporterName = matched.CreatedByUser?.FirstName + " " + matched.CreatedByUser?.LastName;
                }
            }

            var claim = await _claimRepository.AsQueryable()
                .Include(c => c.CreatedByUser)
                .OrderByDescending(c => c.CreatedOn)
                .FirstOrDefaultAsync(c => (c.LostItemId == id || c.FoundItemId == id) && c.Status != ClaimStatus.VerificationFailed);
            
            if (claim != null)
            {
                dto.ClaimId = claim.Id;
                dto.LatestClaimStatus = claim.Status;
                dto.ClaimDescription = claim.ClaimDescription;
                dto.ClaimantName = claim.CreatedByUser?.FirstName + " " + claim.CreatedByUser?.LastName;
            }

            return Response<GetItemDto>.SetSuccessResponse(dto);
        }

        /// <summary>
        /// Administrative Listing Engine: Fetches reports based on tab categorization (Lost, Found, Matching).
        /// Optimized with a 'MatchedCache' pattern to avoid N+1 queries during listing.
        /// </summary>
        public async Task<Response<PagedItemResponseDto>> GetAllAsync(int start = 0, int length = 50, string tab = "all", string? search = null)
        {
            // 1. Fetch comprehensive metadata using Non-Tracking queries for production performance
            var query = _itemRepository.AsNoTracking()
                .Where(x => x.Status == ItemStatus.Lost || x.Status == ItemStatus.Found || x.Status == ItemStatus.Replacement || x.Status == ItemStatus.Auction);

            if (!string.IsNullOrWhiteSpace(search))
            {
                var s = search.ToLower();
                query = query.Where(x => 
                    (x.ItemType.Name.ToLower().Contains(s)) || 
                    (x.CreatedByUser.FirstName.ToLower().Contains(s)) ||
                    (x.CreatedByUser.LastName.ToLower().Contains(s))
                );
            }

            var allItemsMetaData = await query.Select(x => new { 
                    x.Id, x.ReportType, x.Status, x.IsVerifiedByAdmin, x.CreatedOn,
                    ItemTypeName = x.ItemType.Name,
                    LocationName = x.Location != null ? x.Location.Name : "General Campus",
                    Reporter = x.CreatedByUser.FirstName + " " + x.CreatedByUser.LastName,
                    ReporterEmail = x.CreatedByUser.Email
                })
                .ToListAsync();

            var claims = await _claimRepository.AsQueryable().Where(c => c.Status != ClaimStatus.VerificationFailed).ToListAsync();
            var lostItems = allItemsMetaData.Where(i => i.ReportType == ReportType.Lost && i.Status != ItemStatus.Handover).ToList();
            var matchingItems = allItemsMetaData.Where(i => i.ReportType == ReportType.Found && i.Status != ItemStatus.Handover && i.IsVerifiedByAdmin 
                && claims.Any(c => c.FoundItemId == i.Id && c.Status != ClaimStatus.HandedOver)).ToList();
            var foundItems = allItemsMetaData.Where(i => i.ReportType == ReportType.Found && i.Status != ItemStatus.Handover 
                && !(i.IsVerifiedByAdmin && claims.Any(c => c.FoundItemId == i.Id && c.Status != ClaimStatus.HandedOver))).ToList();

            var activeSet = tab.ToLower() switch {
                "lost" => lostItems,
                "matching" => matchingItems,
                "found" => foundItems,
                _ => allItemsMetaData
            };

            var finalListingSorted = activeSet.OrderByDescending(x => x.CreatedOn).ToList();
            var pagedIds = finalListingSorted.Skip(start).Take(length).Select(x => x.Id).ToList();

            var pagedItems = await _itemRepository.AsQueryable()
                .Include(x => x.Location).Include(x => x.ItemType).Include(x => x.Attributes).Include(x => x.CreatedByUser)
                .Where(x => pagedIds.Contains(x.Id)).OrderByDescending(x => x.CreatedOn).ToListAsync();

            var dtoList = _mapper.Map<List<GetItemDto>>(pagedItems);
            
            // 3. Batch Metadata resolution to prevent N+1 queries in the loop
            var matches = await _itemMatchRepository.AsQueryable().Where(m => !m.IsMatchResolved).ToListAsync();
            var itemIds = pagedItems.Select(x => x.Id).ToList();
            var pagedMatches = matches.Where(m => itemIds.Contains(m.LostItemId) || itemIds.Contains(m.FoundItemId)).ToList();
            var matchIds = pagedMatches.Select(m => itemIds.Contains(m.LostItemId) ? m.FoundItemId : m.LostItemId).Distinct().ToList();
            var matchedCache = await _itemRepository.AsQueryable()
                .Include(x => x.ItemType).Include(x => x.CreatedByUser).Where(x => matchIds.Contains(x.Id)).ToDictionaryAsync(x => x.Id);

            foreach (var dto in dtoList)
            {
                var match = pagedMatches.FirstOrDefault(m => m.LostItemId == dto.Id || m.FoundItemId == dto.Id);
                if (match != null)
                {
                    dto.HasPotentialMatch = true;
                    dto.MatchFoundItemId = match.LostItemId == dto.Id ? match.FoundItemId : match.LostItemId;
                    if (dto.MatchFoundItemId.HasValue && matchedCache.TryGetValue(dto.MatchFoundItemId.Value, out var matchedObj))
                    {
                        dto.MatchItemType = matchedObj.ItemType?.Name;
                        dto.MatchReporterName = matchedObj.CreatedByUser?.FirstName + " " + matchedObj.CreatedByUser?.LastName;
                    }
                }
            }

            return Response<PagedItemResponseDto>.SetSuccessResponse(new PagedItemResponseDto {
                Items = dtoList, Total = finalListingSorted.Count,
                LostCount = lostItems.Count, FoundCount = foundItems.Count, MatchCount = matchingItems.Count
            });
        }

        /// <summary>
        /// Student Portal Tool: Retrieves only items belonging to the active user.
        /// Includes match previews only if the corresponding item is verified by admin.
        /// </summary>
        public async Task<Response<List<GetItemDto>>> GetMyItemsAsync()
        {
            if (_userData.UserId == 0) return Response<List<GetItemDto>>.SetCustomErrorResponse("Unauthorized", 401);

            var items = await _itemRepository.AsQueryable()
                .Include(x => x.Location).Include(x => x.ItemType).Include(x => x.Attributes)
                .Where(x => x.CreatedBy == _userData.UserId).OrderByDescending(x => x.CreatedOn).ToListAsync();

            var dtoList = _mapper.Map<List<GetItemDto>>(items);
            var userItemIds = items.Select(x => x.Id).ToList();
            
            if (userItemIds.Any())
            {
                var matches = await _itemMatchRepository.AsQueryable()
                    .Include(m => m.LostItem).Include(m => m.FoundItem)
                    .Where(m => (userItemIds.Contains(m.LostItemId) || userItemIds.Contains(m.FoundItemId)) && !m.IsMatchResolved).ToListAsync();

                foreach(var dto in dtoList)
                {
                    var match = matches.FirstOrDefault(m => m.LostItemId == dto.Id || m.FoundItemId == dto.Id);
                    if (match != null)
                    {
                        var isLostReporter = dto.ReportType == ReportType.Lost;
                        // Privacy Constraint: Lost reporters don't see matches until the admin verifies the item exists
                        if (isLostReporter && !match.FoundItem.IsVerifiedByAdmin) 
                        {
                            dto.HasPotentialMatch = false; 
                        }
                        else 
                        {
                            dto.HasPotentialMatch = true;
                            dto.MatchFoundItemId = isLostReporter ? match.FoundItemId : match.LostItemId;
                            dto.IsVerifiedByAdmin = isLostReporter ? match.FoundItem.IsVerifiedByAdmin : match.LostItem.IsVerifiedByAdmin;
                        }
                    }
                }
            }

            return Response<List<GetItemDto>>.SetSuccessResponse(dtoList);
        }

        /// <summary>
        /// Public Inventory Portal: Returns found items currently available in the 'Found' pool.
        /// Blurs forensics by removing attribute metadata for public visibility.
        /// </summary>
        public async Task<Response<List<GetItemDto>>> GetPublicFoundItemsAsync()
        {
            var foundItems = await _itemRepository.AsQueryable()
                .Include(x => x.Location).Include(x => x.ItemType)
                .Where(x => x.ReportType == ReportType.Found && x.Status == ItemStatus.Found)
                .OrderByDescending(x => x.CreatedOn).ToListAsync();

            var dtoList = _mapper.Map<List<GetItemDto>>(foundItems);
            foreach (var dto in dtoList) { dto.Attributes = new List<GetItemAttributes>(); } // Remove detailed forensics

            return Response<List<GetItemDto>>.SetSuccessResponse(dtoList);
        }

        public async Task<Response<string>> DeleteAsync(long id)
        {
            await _itemRepository.DeleteAsync(id);
            return Response<string>.SetSuccessMessageResponse("Item record archived.");
        }

        /// <summary>
        /// Persists media assets to local storage and validates against security constraints.
        /// </summary>
        private async Task<string> SavePhoto(IFormFile photo)
        {
            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif", ".webp" };
            var ext = Path.GetExtension(photo.FileName)?.ToLower();
            if (string.IsNullOrEmpty(ext) || !allowedExtensions.Contains(ext))
                throw new InvalidOperationException("Security Error: Unsupported file format.");

            if (photo.Length > 5 * 1024 * 1024) throw new InvalidOperationException("Limit Error: Image exceeds 5MB.");

            var uploadsRoot = Path.Combine(_environment.WebRootPath, "uploads");
            if (!Directory.Exists(uploadsRoot)) Directory.CreateDirectory(uploadsRoot);

            var fileName = $"{Guid.NewGuid()}{ext}";
            var filePath = Path.Combine(uploadsRoot, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create)) { await photo.CopyToAsync(stream); }

            return $"/uploads/{fileName}";
        }

        /// <summary>
        /// The Forensic Matching Core:
        /// Uses a weighted attribute analysis to suggest connections between Lost and Found reports.
        /// Weights: Identity (30%), Classification (30%), Aesthetics (20%), Location (20%).
        /// </summary>
        private async Task CheckForMatchesAsync(Items newItem)
        {
            var targetType = newItem.ReportType == ReportType.Lost ? ReportType.Found : ReportType.Lost;

            var candidates = await _itemRepository.AsQueryable()
                .Include(x => x.Attributes)
                .Where(x => x.ReportType == targetType && x.ItemTypeId == newItem.ItemTypeId && 
                           (x.Status == ItemStatus.Found || x.Status == ItemStatus.Lost)).ToListAsync();

            foreach (var candidate in candidates)
            {
                double score = 30; // Base score for shared ItemType

                if (newItem.Attributes != null && candidate.Attributes != null)
                {
                    foreach (var attr in newItem.Attributes)
                    {
                        var candidateAttr = candidate.Attributes
                            .FirstOrDefault(a => a.FieldName.Equals(attr.FieldName, StringComparison.OrdinalIgnoreCase));

                        if (candidateAttr != null && candidateAttr.FieldValue.Trim().Equals(attr.FieldValue.Trim(), StringComparison.OrdinalIgnoreCase))
                        {
                            var lowerField = attr.FieldName.ToLower();
                            if (lowerField.Contains("brand")) score += 30; // Identity Match
                            else if (lowerField.Contains("color")) score += 20; // Aesthetic Match
                            else score += 10; // General Property Match
                        }
                    }
                }

                if (newItem.LocationId == candidate.LocationId) score += 20; // Proximity Match

                score = Math.Min(score, 100);

                if (score >= 60)
                {
                    var lostId = newItem.ReportType == ReportType.Lost ? newItem.Id : candidate.Id;
                    var foundId = newItem.ReportType == ReportType.Found ? newItem.Id : candidate.Id;
                    var userIdToNotify = newItem.ReportType == ReportType.Lost ? newItem.CreatedBy : candidate.CreatedBy;

                    var existingMatch = await _itemMatchRepository.AsQueryable()
                        .FirstOrDefaultAsync(m => m.LostItemId == lostId && m.FoundItemId == foundId);

                    if (existingMatch == null)
                    {
                        await _itemMatchRepository.AddAsync(new ItemMatch {
                            LostItemId = lostId, FoundItemId = foundId, MatchConfidenceScore = score,
                            UserId = userIdToNotify, CreatedBy = userIdToNotify, CreatedOn = DateTime.UtcNow
                        });
                    }
                }
            }
        }

        public async Task<Response<bool>> VerifyItemAsync(long id)
        {
            var item = await _itemRepository.GetByIdAsync(id);
            if (item == null) return Response<bool>.NotFoundResponse();

            item.IsVerifiedByAdmin = true;
            item.VerifiedDate = DateTime.UtcNow;
            await _itemRepository.UpdateAsync(item);

            return Response<bool>.SetSuccessResponse(true, "Item state updated to 'Verified'.");
        }

        public async Task<Response<bool>> MoveToAuctionAsync(long id)
        {
            var item = await _itemRepository.GetByIdAsync(id);
            if (item == null) return Response<bool>.NotFoundResponse();

            if (item.ReportType != ReportType.Found || !item.IsVerifiedByAdmin)
                return Response<bool>.SetCustomErrorResponse("Fulfillment Error: Item must be a verified 'Found' report.", 400);

            item.Status = ItemStatus.Auction;
            item.LastModifiedOn = DateTime.UtcNow;
            await _itemRepository.UpdateAsync(item);

            return Response<bool>.SetSuccessResponse(true, "Item staged for auction.");
        }
    }
}
