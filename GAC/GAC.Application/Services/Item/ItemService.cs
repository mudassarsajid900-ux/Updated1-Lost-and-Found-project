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

namespace GAC.Application.Services.Item
{
    /// <summary>
    /// Service responsible for handling all logic related to Lost and Found items.
    /// It manages data persistence, photo uploads, and business rules like reporting limits.
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

        public ItemService(
            IGenericRepository<Items> itemRepository,
            IGenericRepository<ItemAttribute> attributeRepository,
            IMapper mapper,
            UserData userData,
            IWebHostEnvironment environment,
            IGenericRepository<ItemMatch> itemMatchRepository,
            IGenericRepository<GAC.Core.Entities.Claims.ClaimRequest> claimRepository)
        {
            _itemRepository = itemRepository;
            _attributeRepository = attributeRepository;
            _mapper = mapper;
            _userData = userData;
            _environment = environment;
            _itemMatchRepository = itemMatchRepository;
            _claimRepository = claimRepository;
        }

        /// <summary>
        /// Main entry point for creating a report (Lost or Found).
        /// </summary>
        public async Task<Response<GetItemDto>> CreateAsync(CreateItemDto dto)
        {
            // Security Check: Verify user identity exists in the custom UserData context
            if (_userData.UserId == 0)
            {
                return Response<GetItemDto>.SetCustomErrorResponse("User identity not found in request context. Please ensure you are logged in correctly.", StatusCodes.Status401Unauthorized);
            }

            // Check if it's a LOST report (Status 0 = Lost, 1 = Found)
            if (dto.Status == 0)
            {
                return await CreateLostItem(dto);
            }
            else 
            {
                // Logic for FOUND items:
                // 1. Map the DTO to a database entity
                var entity = _mapper.Map<Items>(dto);

                // 2. Handle Photo Upload: Save the file to the 'uploads' folder and store the relative path
                if (dto.Photo != null)
                {
                    entity.ImageUrl = await SavePhoto(dto.Photo);
                }
                else
                {
                    entity.ImageUrl = ""; // Safely satisfy NOT NULL constraint in DB
                }

                // Set CreatedBy for related entities since GenericRepository doesn't do it for sub-entities
                if (entity.Attributes != null)
                {
                    foreach (var attr in entity.Attributes)
                    {
                        attr.CreatedBy = _userData.UserId;
                    }
                }

                // 4. Save to database
                await _itemRepository.AddAsync(entity);
                Console.WriteLine($"[DEBUG] Found Item Created: Id={entity.Id}, CreatedBy={_userData.UserId}");

                // Run matching algorithm for new Found item
                try 
                {
                    await CheckForMatchesAsync(entity);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] Matching algorithm failed for Item {entity.Id}: {ex.Message}");
                    // We don't throw here so the report is still saved successfully
                }

                // 5. Fetch the saved record (including relations) to return as a result
                var result = await GetByIdAsync(entity.Id);
                return Response<GetItemDto>.SetSuccessResponse(
                    result.Data,
                    "Found Report published successfully",
                    StatusCodes.Status201Created);
            }
        }

        /// <summary>
        /// Logic specifically for Lost Item reports.
        /// Includes an 'Anti-Spam' protection rule: Users can only report a limited number of lost items per day.
        /// </summary>
        private async Task<Response<GetItemDto>> CreateLostItem(CreateItemDto dto)
        {
            // Step 1: Check how many LOST reports this user has submitted in the last 24 hours
            var oneDayAgo = DateTime.Now.AddDays(-1);

            var existingLostReports = await _itemRepository
                .AsNoTracking()
                .Where(x => x.CreatedBy == _userData.UserId
                         && x.Status == GAC.Core.Enums.ItemStatus.Lost // Only count Lost items for the limit
                         && x.CreatedOn >= oneDayAgo)
                .ToListAsync();

            // Step 2: If less than 10 (increased for user testing), allow the new submission
            if (existingLostReports.Count < 10)
            {
                var entity = _mapper.Map<Items>(dto);

                // Handle Photo Upload
                if (dto.Photo != null)
                {
                    entity.ImageUrl = await SavePhoto(dto.Photo);
                }
                else
                {
                    entity.ImageUrl = ""; // Safely satisfy NOT NULL constraint in DB
                }

                // Step 3: Link attributes to the user
                if (entity.Attributes != null)
                {
                    foreach (var attr in entity.Attributes)
                    {
                        attr.CreatedBy = _userData.UserId;
                    }
                }

                await _itemRepository.AddAsync(entity);
                Console.WriteLine($"[DEBUG] Lost Item Created: Id={entity.Id}, CreatedBy={_userData.UserId}");

                // Run matching algorithm for new Lost item
                try 
                {
                    await CheckForMatchesAsync(entity);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] Matching algorithm failed for Item {entity.Id}: {ex.Message}");
                }

                var result = await GetByIdAsync(entity.Id);
                return Response<GetItemDto>.SetSuccessResponse(
                    result.Data,
                    "Lost Report submitted successfully",
                    StatusCodes.Status201Created);
            }
            else
            {
                return Response<GetItemDto>.SetCustomErrorResponse("You have reached the limit of 10 lost reports in 24 hours. Please wait before submitting more.", StatusCodes.Status400BadRequest);
            }
        }

        /// <summary>
        /// Updates an existing report and its dynamic attributes.
        /// </summary>
        public async Task<Response<GetItemDto>> UpdateAsync(UpdateItemDto dto)
        {
            // Step 1: Load item WITHOUT attributes (no navigation property to confuse EF)
            var existing = await _itemRepository
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == dto.Id);

            if (existing == null)
                return Response<GetItemDto>.NotFoundResponse();

            // Step 2: Update only scalar fields on the item
            existing.EventTime = dto.EventTime;
            existing.LocationId = dto.LocationId;
            existing.ItemTypeId = dto.ItemTypeId;
            existing.Status = dto.Status;
            // Clear navigation so EF does NOT try to manage attributes during UpdateAsync
            existing.Attributes = null;

            await _itemRepository.UpdateAsync(existing);

            // Step 3: Delete all old attributes for this item directly via attribute repository
            var oldAttrs = await _attributeRepository
                .AsNoTracking()
                .Where(a => a.LostItemId == dto.Id)
                .ToListAsync();

            if (oldAttrs.Any())
                await _attributeRepository.DeleteListAsync(oldAttrs);

            // Step 4: Insert fresh new attributes (all required fields set explicitly)
            if (dto.Attributes != null && dto.Attributes.Any())
            {
                var newAttrs = dto.Attributes.Select(a => new ItemAttribute
                {
                    FieldName = a.FieldName,
                    FieldValue = a.FieldValue,
                    LostItemId = existing.Id,
                    CreatedBy = existing.CreatedBy,
                    CreatedOn = DateTime.UtcNow,
                    LastModifiedBy = existing.CreatedBy,
                    LastModifiedOn = DateTime.UtcNow,
                    IsActive = true,
                    IsDeleted = false
                }).ToList();

                await _attributeRepository.AddRangeAsync(newAttrs);
            }

            // PERFECTION: Re-trigger matching algorithm in case attributes or location changed
            try
            {
                // We need the full entity with current attributes for the matching logic
                var updatedEntity = await _itemRepository.AsQueryable()
                    .Include(x => x.Attributes)
                    .FirstOrDefaultAsync(x => x.Id == existing.Id);
                
                if (updatedEntity != null && (updatedEntity.Status == ItemStatus.Lost || updatedEntity.Status == ItemStatus.Found))
                {
                    await CheckForMatchesAsync(updatedEntity);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] Live Re-Match failed for Item {existing.Id}: {ex.Message}");
            }

            var updated = await GetByIdAsync(existing.Id);

            return Response<GetItemDto>.SetSuccessResponse(
                updated.Data,
                "Item updated successfully");
        }

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

            // IDOR Protection: Students can only view their own items (Admins see all)
            if (_userData != null && _userData.Role != "Admin" && entity.CreatedBy != _userData.UserId)
            {
                return Response<GetItemDto>.SetCustomErrorResponse("Access Denied: You do not have permission to view this report.", StatusCodes.Status403Forbidden);
            }

            var dto = _mapper.Map<GetItemDto>(entity);

            // Check for match
            var match = await _itemMatchRepository.AsQueryable()
                .FirstOrDefaultAsync(m => (m.LostItemId == id || m.FoundItemId == id) && !m.IsMatchResolved);
            
            if (match != null)
            {
                dto.HasPotentialMatch = true;
                dto.MatchFoundItemId = match.LostItemId == id ? match.FoundItemId : match.LostItemId;
                
                // Load details for match comparison in Admin UI
                var matched = await _itemRepository.AsQueryable().Include(x => x.ItemType).Include(x => x.CreatedByUser).FirstOrDefaultAsync(x => x.Id == dto.MatchFoundItemId);
                if (matched != null)
                {
                    dto.MatchItemType = matched.ItemType?.Name;
                    dto.MatchReporterName = matched.CreatedByUser?.FirstName + " " + matched.CreatedByUser?.LastName;
                }
            }

            // Check for claim
            var claim = await _claimRepository.AsQueryable()
                .Include(c => c.CreatedByUser)
                .OrderByDescending(c => c.CreatedOn)
                .FirstOrDefaultAsync(c => (c.LostItemId == id || c.FoundItemId == id) && c.Status != ClaimStatus.VerificationFailed);
            
            if (claim != null)
            {
                dto.ClaimId = claim.Id;
                dto.LatestClaimStatus = claim.Status;
                dto.ClaimRejectionReason = claim.RejectionReason;
                dto.ClaimDescription = claim.ClaimDescription;
                dto.ClaimantName = claim.CreatedByUser?.FirstName + " " + claim.CreatedByUser?.LastName;
                dto.ClaimantEmail = claim.CreatedByUser?.Email;
            }

            // Conflict count (how many users claimed this FOUND item)
            if (entity.ReportType == ReportType.Found)
            {
                dto.ActiveClaimCount = await _claimRepository.AsQueryable()
                    .CountAsync(c => c.FoundItemId == id && c.Status != ClaimStatus.VerificationFailed);
            }

            return Response<GetItemDto>.SetSuccessResponse(dto);
        }


        public async Task<Response<PagedItemResponseDto>> GetAllAsync(int start = 0, int length = 50, string tab = "all", string? search = null)
        {
            // 1. Unified truth: Get basic metadata for ALL non-deleted items with valid Locations
            // This INNER JOIN on Location ensures orphaned items are EXCLUDED from all counts and lists.
            var allValidItems = await _itemRepository.AsQueryable()
                .Where(x => x.Status == ItemStatus.Lost || x.Status == ItemStatus.Found || x.Status == ItemStatus.Replacement)
                .Where(x => x.Location != null && !x.Location.IsDeleted)
                .Select(x => new { 
                    x.Id, 
                    x.ReportType, 
                    x.Status, 
                    x.IsVerifiedByAdmin, 
                    x.CreatedOn,
                    ItemTypeName = x.ItemType.Name,
                    LocationName = x.Location.Name,
                    Reporter = x.CreatedByUser.FirstName + " " + x.CreatedByUser.LastName,
                    ReporterEmail = x.CreatedByUser.Email
                })
                .ToListAsync();

            // 1b. Apply Search Filter if provided
            if (!string.IsNullOrWhiteSpace(search))
            {
                var s = search.ToLower();
                allValidItems = allValidItems.Where(x => 
                    (x.ItemTypeName?.ToLower().Contains(s) ?? false) || 
                    (x.LocationName?.ToLower().Contains(s) ?? false) || 
                    (x.Reporter?.ToLower().Contains(s) ?? false) || 
                    (x.ReporterEmail?.ToLower().Contains(s) ?? false)
                ).ToList();
            }

            // 2. Fetch matches/claims to handle complex tab splits
            var matches = await _itemMatchRepository.AsQueryable().Where(m => !m.IsMatchResolved).ToListAsync();
            var claims = await _claimRepository.AsQueryable().Where(c => c.Status != ClaimStatus.VerificationFailed).ToListAsync();

            // 3. Tab logic (Categorize the valid items)
            var lostItems = allValidItems.Where(i => i.ReportType == ReportType.Lost && i.Status != ItemStatus.Handover).ToList();

            // FIXED: Matching tab shows any Found item that has an active (non-failed, non-handed-over) claim.
            // We do NOT require an active ItemMatch record because when admin approves a claim,
            // the match is resolved (IsMatchResolved=true), but the item is still awaiting physical handover.
            // The claim record is the correct source of truth for "is this a matching case?".
            var matchingItems = allValidItems.Where(i => i.ReportType == ReportType.Found && i.Status != ItemStatus.Handover && i.IsVerifiedByAdmin 
                && claims.Any(c => c.FoundItemId == i.Id && c.Status != ClaimStatus.HandedOver)).ToList();
            
            // Found tab: verified found items that have NO active claim (pure found items not yet matched/claimed)
            var foundItems = allValidItems.Where(i => i.ReportType == ReportType.Found && i.Status != ItemStatus.Handover 
                && !(i.IsVerifiedByAdmin && claims.Any(c => c.FoundItemId == i.Id && c.Status != ClaimStatus.HandedOver))).ToList();

            // 4. Select the active tab's set for pagination
            var activeSet = tab.ToLower() switch {
                "lost" => lostItems,
                "matching" => matchingItems,
                "found" => foundItems,
                _ => allValidItems
            };

            // 5. Final pagination and ID selection
            var finalListingSorted = activeSet.OrderByDescending(x => x.CreatedOn).ToList();
            int totalCount = finalListingSorted.Count();
            
            var pagedIds = finalListingSorted
                .Skip(start)
                .Take(length)
                .Select(x => x.Id)
                .ToList();

            // 6. Detailed fetch for the exact 10 records needed
            var pagedItems = await _itemRepository.AsQueryable()
                .Include(x => x.Location)
                .Include(x => x.ItemType)
                .Include(x => x.Attributes)
                .Include(x => x.CreatedByUser)
                .Where(x => pagedIds.Contains(x.Id))
                .OrderByDescending(x => x.CreatedOn)
                .ToListAsync();

            var dtoList = _mapper.Map<List<GetItemDto>>(pagedItems);
            var itemIds = pagedItems.Select(x => x.Id).ToList();

            var pagedMatches = matches.Where(m => itemIds.Contains(m.LostItemId) || itemIds.Contains(m.FoundItemId)).ToList();
            var pagedClaims = claims.Where(c => (itemIds.Contains(c.LostItemId) || itemIds.Contains(c.FoundItemId))).ToList();

            foreach (var dto in dtoList)
            {
                var match = pagedMatches.FirstOrDefault(m => m.LostItemId == dto.Id || m.FoundItemId == dto.Id);
                if (match != null)
                {
                    dto.HasPotentialMatch = true;
                    dto.MatchFoundItemId = match.LostItemId == dto.Id ? match.FoundItemId : match.LostItemId;

                    // Support Admin UI with better labels
                    var matchedId = dto.MatchFoundItemId;
                    var matchedObj = await _itemRepository.AsQueryable().Include(x => x.ItemType).Include(x => x.CreatedByUser).FirstOrDefaultAsync(x => x.Id == matchedId);
                    if (matchedObj != null)
                    {
                        dto.MatchItemType = matchedObj.ItemType?.Name;
                        dto.MatchReporterName = matchedObj.CreatedByUser?.FirstName + " " + matchedObj.CreatedByUser?.LastName;
                    }
                }

                var claim = pagedClaims.FirstOrDefault(c => (c.LostItemId == dto.Id || c.FoundItemId == dto.Id));
                if (claim != null)
                {
                    dto.ClaimId = claim.Id;
                    dto.LatestClaimStatus = claim.Status;
                    dto.ClaimRejectionReason = claim.RejectionReason;
                    dto.ClaimDescription = claim.ClaimDescription;
                    dto.ClaimantName = claim.CreatedByUser?.FirstName + " " + claim.CreatedByUser?.LastName;
                    dto.ClaimantEmail = claim.CreatedByUser?.Email;
                }

                if (dto.ReportType == ReportType.Found)
                {
                    dto.ActiveClaimCount = claims.Count(c => c.FoundItemId == dto.Id);
                }
            }

            var result = new PagedItemResponseDto
            {
                Items = dtoList,
                Total = totalCount,
                LostCount = lostItems.Count,
                FoundCount = foundItems.Count,
                MatchCount = matchingItems.Count
            };

            return Response<PagedItemResponseDto>.SetSuccessResponse(result);
        }

        /// <summary>
        /// Returns all reports submitted by the currently logged-in user.
        /// </summary>
        public async Task<Response<List<GetItemDto>>> GetMyItemsAsync()
        {
            try
            {
                if (_userData.UserId == 0)
                {
                    return Response<List<GetItemDto>>.SetCustomErrorResponse("User identity not found.", StatusCodes.Status401Unauthorized);
                }

                var items = await _itemRepository.AsQueryable()
                    .Include(x => x.Location)
                    .Include(x => x.ItemType)
                    .Include(x => x.Attributes)
                    .Where(x => x.CreatedBy == _userData.UserId)
                    .OrderByDescending(x => x.CreatedOn)
                    .ToListAsync();

                var dtoList = _mapper.Map<List<GetItemDto>>(items);

                // Fetch matches including the items to check verification status
                var userItemIds = items.Select(x => x.Id).ToList();
                var matches = new List<ItemMatch>();
                if (userItemIds.Any())
                {
                    matches = await _itemMatchRepository.AsQueryable()
                        .Include(m => m.LostItem)
                        .Include(m => m.FoundItem)
                        .Where(m => (userItemIds.Contains(m.LostItemId) || userItemIds.Contains(m.FoundItemId)) && !m.IsMatchResolved)
                        .ToListAsync();
                }

                foreach(var dto in dtoList)
                {
                    var match = matches.FirstOrDefault(m => m.LostItemId == dto.Id || m.FoundItemId == dto.Id);
                    if (match != null)
                    {
                        var isLostReporter = dto.ReportType == ReportType.Lost;
                        var otherSideVerified = isLostReporter ? match.FoundItem.IsVerifiedByAdmin : true; // Found items always see their match? Or do they? The user said "Matching not start until...". 

                        if (isLostReporter && !match.FoundItem.IsVerifiedByAdmin)
                        {
                            // Hidden from user because it's not in office yet
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

                return Response<List<GetItemDto>>.SetSuccessResponse(dtoList);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR IN GetMyItemsAsync: " + ex.ToString());
                throw;
            }
        }

        public async Task<Response<List<GetItemDto>>> GetPublicFoundItemsAsync()
        {
            var foundItems = await _itemRepository.AsQueryable()
                .Include(x => x.Location)
                .Include(x => x.ItemType)
                .Where(x => x.ReportType == ReportType.Found && x.Status == ItemStatus.Found)
                .OrderByDescending(x => x.CreatedOn)
                .ToListAsync();

            var dtoList = _mapper.Map<List<GetItemDto>>(foundItems);

            // Hide sensitive attributes for privacy
            foreach (var dto in dtoList)
            {
                if (dto.Attributes != null)
                {
                    dto.Attributes = new List<GetItemAttributes>();
                }
            }

            return Response<List<GetItemDto>>.SetSuccessResponse(dtoList);
        }

        public async Task<Response<string>> DeleteAsync(long id)
        {
            var entity = await _itemRepository.GetByIdAsync(id);

            if (entity == null)
                return Response<string>.NotFoundResponse();

            await _itemRepository.DeleteAsync(id);

            return Response<string>.SetSuccessMessageResponse("Item deleted successfully");
        }

        private async Task<string> SavePhoto(IFormFile photo)
        {
            var uploadsRoot = Path.Combine(_environment.WebRootPath, "uploads");
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

            return "/uploads/" + fileName;
        }

        private async Task CheckForMatchesAsync(Items newItem)
        {
            // We only match Lost to Found and vice-versa
            var targetType = newItem.ReportType == GAC.Core.Enums.ReportType.Lost
                ? GAC.Core.Enums.ReportType.Found
                : GAC.Core.Enums.ReportType.Lost;

            var candidates = await _itemRepository.AsQueryable()
                .Include(x => x.Attributes)
                // FIXED: Only match against items that are still actively available (Lost or Found).
                // Items already in Replacement(2), Auction(3), Handover(4), ReplacementHandover(5), 
                // or AuctionHandover(6) should NOT appear as match candidates.
                .Where(x => x.ReportType == targetType && 
                           x.ItemTypeId == newItem.ItemTypeId && 
                           (x.Status == GAC.Core.Enums.ItemStatus.Found || x.Status == GAC.Core.Enums.ItemStatus.Lost))
                .ToListAsync();

            foreach (var candidate in candidates)
            {
                double score = 0;
                
                // Base 30% for being the same ItemType (already filtered above)
                score += 30;

                // Compare Attributes
                if (newItem.Attributes != null && candidate.Attributes != null)
                {
                    foreach (var attr in newItem.Attributes)
                    {
                        var candidateAttr = candidate.Attributes
                            .FirstOrDefault(a => a.FieldName.Equals(attr.FieldName, StringComparison.OrdinalIgnoreCase));

                        if (candidateAttr != null && candidateAttr.FieldValue.Equals(attr.FieldValue, StringComparison.OrdinalIgnoreCase))
                        {
                            var lowerField = attr.FieldName.ToLower();
                            if (lowerField.Contains("brand")) score += 30;
                            else if (lowerField.Contains("color") || lowerField.Contains("colour")) score += 20;
                            else score += 10;
                        }
                    }
                }

                // Location match (optional)
                if (newItem.LocationId == candidate.LocationId)
                {
                    score += 20;
                }

                // If score > 60, create match
                // We cap at 100
                score = Math.Min(score, 100);

                if (score >= 60)
                {
                    var lostId = newItem.ReportType == GAC.Core.Enums.ReportType.Lost ? newItem.Id : candidate.Id;
                    var foundId = newItem.ReportType == GAC.Core.Enums.ReportType.Found ? newItem.Id : candidate.Id;
                    var userIdToNotify = newItem.ReportType == GAC.Core.Enums.ReportType.Lost ? newItem.CreatedBy : candidate.CreatedBy;

                    // Avoid duplicate match
                    var existingMatch = await _itemMatchRepository.AsQueryable()
                        .FirstOrDefaultAsync(m => m.LostItemId == lostId && m.FoundItemId == foundId);

                    if (existingMatch == null)
                    {
                        var match = new ItemMatch
                        {
                            LostItemId = lostId,
                            FoundItemId = foundId,
                            MatchConfidenceScore = score,
                            UserId = userIdToNotify,
                            CreatedBy = userIdToNotify,
                            CreatedOn = DateTime.UtcNow
                        };
                        await _itemMatchRepository.AddAsync(match);
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

            return Response<bool>.SetSuccessResponse(true, "Item receipt verified successfully.");
        }
    }
}
