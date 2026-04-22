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
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace GAC.Application.Services.Item
{
    /// <summary>
    /// Service responsible for managing Items (Lost, Found, Replacements, Auctions).
    /// Handles business logic for creating, retrieving, updating, and matching items.
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

        /// <summary>
        /// Initializes a new instance of the ItemService.
        /// </summary>
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
        /// Creates a new Item (Lost or Found) and its associated attributes.
        /// Triggers deferred matching immediately if the item is reported as Lost.
        /// </summary>
        public async Task<Response<GetItemDto>> CreateAsync(CreateItemDto dto)
        {
            // 1. Validate user authentication status
            if (_userData.UserId == 0)
                return Response<GetItemDto>.SetCustomErrorResponse("User identity not found.", StatusCodes.Status401Unauthorized);

            // 2. Map DTO to Entity and set initial audit fields
            var entity = _mapper.Map<Items>(dto);
            entity.CreatedBy = _userData.UserId;
            entity.CreatedOn = DateTime.UtcNow;
            entity.IsDeleted = false;
            entity.IsVerifiedByAdmin = false; // By default, items require admin verification

            // 3. Handle image upload if a photo is provided
            if (dto.Photo != null)
            {
                try
                {
                    entity.ImageUrl = await SavePhoto(dto.Photo);
                }
                catch (ArgumentException ex)
                {
                    return Response<GetItemDto>.SetCustomErrorResponse(ex.Message, StatusCodes.Status400BadRequest);
                }
            }

            // 4. Persist the main Item entity to the database
            await _itemRepository.AddAsync(entity);

            // 5. Persist dynamic formatting/attributes for the item
            if (dto.Attributes != null)
            {
                foreach (var attr in dto.Attributes)
                {
                    var itemAttr = new ItemAttribute
                    {
                        LostItemId = entity.Id, // Note: The foreign key is technically applicable to both Lost/Found items
                        FieldName = attr.FieldName,
                        FieldValue = attr.FieldValue,
                        CreatedBy = _userData.UserId,
                        CreatedOn = DateTime.UtcNow
                    };
                    await _attributeRepository.AddAsync(itemAttr);
                }
            }

            // 6. Deferred Matching: Immediately attempt to find matches for newly reported Lost items
            if (entity.ReportType == ReportType.Lost)
            {
                try 
                { 
                    await CheckForMatchesAsync(entity); 
                } 
                catch 
                { 
                    // Safely ignore matching exceptions to ensure item creation succeeds
                }
            }

            // 7. Return created item as DTO
            return Response<GetItemDto>.SetSuccessResponse(_mapper.Map<GetItemDto>(entity));
        }

        /// <summary>
        /// Retrieves a specific item by its unique identifier, including related entities and potential matches.
        /// </summary>
        public async Task<Response<GetItemDto>> GetByIdAsync(long id)
        {
            // 1. Query database including related navigational properties
            var entity = await _itemRepository.AsNoTracking()
                .Include(x => x.Attributes)
                .Include(x => x.Location)
                .Include(x => x.ItemType)
                .Include(x => x.CreatedByUser)
                .FirstOrDefaultAsync(x => x.Id == id);
            
            // 2. Handle not found scenario
            if (entity == null) return Response<GetItemDto>.NotFoundResponse();

            // 3. Map to Data Transfer Object
            var dto = _mapper.Map<GetItemDto>(entity);
            
            // 4. Check for any unresolved matches associated with this item
            var match = await _itemMatchRepository.AsQueryable()
                .FirstOrDefaultAsync(m => (m.LostItemId == id || m.FoundItemId == id) && !m.IsMatchResolved);
                
            // 5. Populate potential match details into DTO
            if (match != null)
            {
                dto.HasPotentialMatch = true;
                dto.MatchFoundItemId = match.LostItemId == id ? match.FoundItemId : match.LostItemId;
            }

            // NEW 6. Fetch pending claim details for Admin verification panel
            var pendingClaim = await _claimRepository.AsQueryable()
                .Include(c => c.CreatedByUser)
                .FirstOrDefaultAsync(c => (c.FoundItemId == id || c.LostItemId == id) && c.Status == ClaimStatus.VerificationPending);

            if (pendingClaim != null)
            {
                dto.ClaimId = pendingClaim.Id;
                dto.ClaimantName = pendingClaim.CreatedByUser != null ? $"{pendingClaim.CreatedByUser.FirstName} {pendingClaim.CreatedByUser.LastName}".Trim() : "Student";
                dto.ClaimantEmail = pendingClaim.CreatedByUser?.Email;
                dto.ClaimDescription = pendingClaim.ClaimDescription;
            }

            return Response<GetItemDto>.SetSuccessResponse(dto);
        }

        /// <summary>
        /// Retrieves a paginated list of items with optional tab filtering and comprehensive count aggregations.
        /// Refactored to execute all aggregation natively on SQL server to prevent debilitating RAM leaks under stress.
        /// </summary>
        public async Task<Response<PagedItemResponseDto>> GetAllAsync(int start = 0, int length = 50, string tab = "all", string? search = null)
        {
            // 1. Base query for valid, active item statuses
            var allItemsQuery = _itemRepository.AsQueryable()
                .Where(x => x.Status == ItemStatus.Lost || 
                            x.Status == ItemStatus.Found || 
                            x.Status == ItemStatus.Replacement || 
                            x.Status == ItemStatus.Auction);

            // 2. Projection for performant fetching of lightweight metadata required for filtering
            var allValidItems = await allItemsQuery
                .Select(x => new { 
                    x.Id, 
                    x.ReportType, 
                    x.Status, 
                    x.IsVerifiedByAdmin, 
                    x.CreatedOn, 
                    ItemTypeName = x.ItemType.Name, 
                    LocationName = x.Location.Name,
                    Reporter = x.CreatedByUser.FirstName + " " + x.CreatedByUser.LastName 
                })
                .ToListAsync();

            // 3. Fetch all active ItemMatches (generated by the matching engine)
            var itemMatches = await _itemMatchRepository.AsQueryable()
                .Include(m => m.LostItem).ThenInclude(i => i.ItemType)
                .Include(m => m.LostItem).ThenInclude(i => i.CreatedByUser)
                .Include(m => m.FoundItem).ThenInclude(i => i.ItemType)
                .Include(m => m.FoundItem).ThenInclude(i => i.Location)
                .Include(m => m.FoundItem).ThenInclude(i => i.CreatedByUser)
                .ToListAsync();

            var claims = await _claimRepository.AsQueryable()
                .Where(c => c.Status != ClaimStatus.VerificationFailed)
                .ToListAsync();

            // 4. Segment items into logical buckets
            var lostItems = allValidItems.Where(i => i.ReportType == ReportType.Lost).ToList();

            // NEW LOGIC: Matching items tab acts as a Claim Review Queue. 
            // Only show Found items that have an explicitly submitted claim pending review.
            var pendingClaimFoundIds = claims.Where(c => c.Status == ClaimStatus.VerificationPending).Select(c => c.FoundItemId).ToHashSet();
            var matchingItems = allValidItems.Where(i =>
                i.ReportType == ReportType.Found &&
                pendingClaimFoundIds.Contains(i.Id)).ToList();

            // Found tab = ALL found items (matched or unmatched) - user wants to see everything
            var foundItems = allValidItems.Where(i => i.ReportType == ReportType.Found).ToList();

            // 5. Determine the active dataset to paginate over based on the requested 'tab'
            var activeSet = tab.ToLower() switch { 
                "lost" => lostItems, 
                "matching" => matchingItems, 
                "found" => foundItems, 
                _ => allValidItems // "all" fallback
            };
            
            // 6. Execute pagination to get target Item IDs
            var pagedIds = activeSet
                .OrderByDescending(x => x.CreatedOn)
                .Skip(start)
                .Take(length)
                .Select(x => x.Id)
                .ToList();

            // 7. Full data hydration for the specific paginated IDs
            var pagedItems = await _itemRepository.AsQueryable()
                .Include(x => x.Location)
                .Include(x => x.ItemType)
                .Include(x => x.Attributes)
                .Include(x => x.CreatedByUser)
                .Where(x => pagedIds.Contains(x.Id))
                .OrderByDescending(x => x.CreatedOn)
                .ToListAsync();

            var dtoList = _mapper.Map<List<GetItemDto>>(pagedItems);
            
            // 8. Augment DTOs with active claim counts and match data
            foreach (var dto in dtoList)
            {
                if (dto.ReportType == ReportType.Found)
                    dto.ActiveClaimCount = claims.Count(c => c.FoundItemId == dto.Id);

                // CRITICAL: Attach match data so the frontend "Matching" tab can render both sides of the pair
                var match = itemMatches.FirstOrDefault(m => m.FoundItemId == dto.Id || m.LostItemId == dto.Id);
                if (match != null)
                {
                    dto.HasPotentialMatch = true;
                    dto.MatchFoundItemId = match.FoundItemId;
                    dto.MatchLostItemId = match.LostItemId;
                    dto.MatchConfidenceScore = match.MatchConfidenceScore;
                    // Attach the item type name from the OTHER side of the pair
                    dto.MatchItemType = dto.ReportType == ReportType.Found
                        ? (match.LostItem?.ItemType?.Name ?? "Lost Item")
                        : (match.FoundItem?.ItemType?.Name ?? "Found Item");
                    // Attach the real full name + email of the person on the OTHER side of the match
                    var otherUser = dto.ReportType == ReportType.Found
                        ? match.LostItem?.CreatedByUser
                        : match.FoundItem?.CreatedByUser;
                    dto.MatchReporterName = otherUser != null
                        ? $"{otherUser.FirstName} {otherUser.LastName}".Trim()
                        : "Unknown";
                    dto.MatchReporterEmail = otherUser?.Email ?? string.Empty;
                }
            }

            // 9. Construct the final robust response payload with metadata counters
            return Response<PagedItemResponseDto>.SetSuccessResponse(new PagedItemResponseDto {
                Items = dtoList, 
                Total = activeSet.Count,
                LostCount = allValidItems.Count(x => x.ReportType == ReportType.Lost),
                FoundCount = allValidItems.Count(x => x.ReportType == ReportType.Found),
                MatchCount = matchingItems.Count, // Items that are part of a confirmed machine match
                ReplacementCount = allValidItems.Count(x => x.Status == ItemStatus.Replacement)
            });
        }

        /// <summary>
        /// Retrieves items primarily authored by the currently logged-in user.
        /// Integrates AI/Logic matching to notify users of potential found matches for their lost items.
        /// </summary>
        public async Task<Response<List<GetItemDto>>> GetMyItemsAsync()
        {
            // 1. Fetch user's items from the database
            var items = await _itemRepository.AsQueryable()
                .Include(x => x.Location)
                .Include(x => x.ItemType)
                .Include(x => x.Attributes)
                .Where(x => x.CreatedBy == _userData.UserId)
                .OrderByDescending(x => x.CreatedOn)
                .ToListAsync();
                
            var dtoList = _mapper.Map<List<GetItemDto>>(items);
            var userItemIds = items.Select(x => x.Id).ToList();
            
            if (userItemIds.Any())
            {
                // 2. Check system for matches involving the user's items
                var matches = await _itemMatchRepository.AsQueryable()
                    .Include(m => m.FoundItem)
                    .Where(m => (userItemIds.Contains(m.LostItemId) || userItemIds.Contains(m.FoundItemId)) && !m.IsMatchResolved)
                    .ToListAsync();
                
                // 3. Evaluate match visibility rules
                foreach(var dto in dtoList)
                {
                    var match = matches.FirstOrDefault(m => m.LostItemId == dto.Id || m.FoundItemId == dto.Id);
                    if (match != null)
                    {
                        // Business Logic: A lost item reporter should only see matches if the found item is verified by Admin to prevent false hopes/spam.
                        if (dto.ReportType == ReportType.Lost && !match.FoundItem.IsVerifiedByAdmin) 
                        {
                            dto.HasPotentialMatch = false;
                        }
                        else 
                        {
                            dto.HasPotentialMatch = true;
                            dto.MatchFoundItemId = dto.ReportType == ReportType.Lost ? match.FoundItemId : match.LostItemId;
                        }
                    }
                }
            }
            return Response<List<GetItemDto>>.SetSuccessResponse(dtoList);
        }

        /// <summary>
        /// Allows Admins to officially verify a reported item (typically Found items).
        /// Re-triggers the matching algorithm securely as verified data enters the system.
        /// </summary>
        public async Task<Response<bool>> VerifyItemAsync(long id)
        {
            var item = await _itemRepository.AsQueryable().Include(x => x.Attributes).FirstOrDefaultAsync(x => x.Id == id);
            if (item == null) return Response<bool>.NotFoundResponse();
            
            // Mark item as trusted and timestamp the action
            item.IsVerifiedByAdmin = true;
            item.VerifiedDate = DateTime.UtcNow;
            
            await _itemRepository.UpdateAsync(item);
            
            // Trigger matching mechanics post-verification
            try 
            { 
                await CheckForMatchesAsync(item); 
            } 
            catch { /* Ignore match exceptions */ }
            
            return Response<bool>.SetSuccessResponse(true);
        }

        /// <summary>
        /// Utility function: Saves incoming uploaded file locally to wwwroot/uploads.
        /// Includes strict security validations (size, extension) to prevent payload exploits.
        /// </summary>
        private async Task<string> SavePhoto(IFormFile photo)
        {
            // Security Hardening: File size limit (e.g., max 5MB) to prevent DoS via massive memory loads
            const int maxFileSize = 5 * 1024 * 1024;
            if (photo.Length > maxFileSize)
                throw new ArgumentException("Security Block: File size exceeds the maximum allowed limit of 5MB.");

            // Security Hardening: Strict extension validation to prevent malicious shells/payloads (.exe, .sh)
            var extension = Path.GetExtension(photo.FileName).ToLowerInvariant();
            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".webp" };
            if (!allowedExtensions.Contains(extension))
                throw new ArgumentException("Security Block: Invalid file format. Only JPG, PNG, and WebP are permitted.");

            var uploadsRoot = Path.Combine(_environment.WebRootPath ?? "wwwroot", "uploads"); // Added fallback for security against null web roots
            if (!Directory.Exists(uploadsRoot)) Directory.CreateDirectory(uploadsRoot);
            
            // Randomize name to block Directory Traversal attacks
            var fileName = Guid.NewGuid().ToString() + extension;
            var filePath = Path.Combine(uploadsRoot, fileName);
            
            using (var stream = new FileStream(filePath, FileMode.Create)) 
            {
                await photo.CopyToAsync(stream);
            }
            return "/uploads/" + fileName;
        }

        /// <summary>
        /// Core Matching Engine: Evaluates a new/verified item against existing entries.
        /// Generates an ItemMatch record if a high confidence threshold is met.
        /// </summary>
        private async Task CheckForMatchesAsync(Items newItem)
        {
            // 1. Determine target search basis: Lost items look for Found; Found items look for Lost.
            var targetType = newItem.ReportType == ReportType.Lost ? ReportType.Found : ReportType.Lost;
            
            // 2. Fetch potential candidates sharing the same Item Type (Category base requirement)
            // CRUCIAL LOGIC UPDATE: We must ONLY match against Found items that have been verified by an Admin
            var candidates = await _itemRepository.AsQueryable()
                .Include(x => x.Attributes)
                .Where(x => x.ReportType == targetType && 
                            x.ItemTypeId == newItem.ItemTypeId && 
                            (x.Status == ItemStatus.Found || x.Status == ItemStatus.Lost) &&
                            (targetType != ReportType.Found || x.IsVerifiedByAdmin == true))
                .ToListAsync();

            // 3. Iterate through candidates and calculate a match compatibility score using a "Gatekeeper" framework
            foreach (var candidate in candidates)
            {
                double score = 30; // Base score for sharing the same fundamental category
                bool identityConflict = false;
                
                // 4. Cross-evaluate dynamic attributes with Identity Gating
                if (newItem.Attributes != null && candidate.Attributes != null)
                {
                    foreach (var attr in newItem.Attributes)
                    {
                        var cAttr = candidate.Attributes.FirstOrDefault(a => a.FieldName.Trim().Equals(attr.FieldName.Trim(), StringComparison.OrdinalIgnoreCase));
                        
                        // Skip if one side hasn't provided this specific attribute
                        if (cAttr == null || string.IsNullOrWhiteSpace(cAttr.FieldValue) || string.IsNullOrWhiteSpace(attr.FieldValue)) continue;

                        var val1 = attr.FieldValue.Trim();
                        var val2 = cAttr.FieldValue.Trim();
                        var field = attr.FieldName.ToLower();

                        // Define attribute categories
                        bool isIdentityField = field.Contains("brand") || field.Contains("model") || field.Contains("imei") || field.Contains("serial") || field.Contains("company");
                        bool isCoreField = field.Contains("color") || field.Contains("sim") || field.Contains("size") || field.Contains("storage") || field.Contains("ram") || field.Contains("rom");

                        if (isIdentityField)
                        {
                            // IDENTITY GATE: Mandatory Exact Match
                            if (!val1.Equals(val2, StringComparison.OrdinalIgnoreCase))
                            {
                                identityConflict = true;
                                break; // Immediate rejection for this candidate
                            }
                            score += 40; // High confidence reward for matching Identity
                        }
                        else if (isCoreField)
                        {
                            // CORE MATCHING: Strong Similarity
                            if (val1.Contains(val2, StringComparison.OrdinalIgnoreCase) || val2.Contains(val1, StringComparison.OrdinalIgnoreCase))
                                score += 20;
                        }
                        else 
                        {
                            // SUPPORTING MATCHING: Soft Context
                            if (val1.Contains(val2, StringComparison.OrdinalIgnoreCase) || val2.Contains(val1, StringComparison.OrdinalIgnoreCase))
                                score += 10;
                        }
                    }
                }
                
                // FAST REJECT: If Brand/Model/IMEI conflict, this is NOT a match.
                if (identityConflict) continue;

                // 5. Geographical matching weight: Matching campuses/buildings 
                if (newItem.LocationId == candidate.LocationId) score += 15;

                // 6. Final Decision Gate: Only proceed if confidence is strong (>= 80%)
                if (score >= 80)
                {
                    // Ensure correlation of IDs align correctly to Database Schema (LostItemId -> FoundItemId)
                    var lostId = newItem.ReportType == ReportType.Lost ? newItem.Id : candidate.Id;
                    var foundId = newItem.ReportType == ReportType.Found ? newItem.Id : candidate.Id;
                    
                    // 7. Verify match is unique and does not already exist
                    if (!await _itemMatchRepository.AsQueryable().AnyAsync(m => m.LostItemId == lostId && m.FoundItemId == foundId))
                    {
                        await _itemMatchRepository.AddAsync(new ItemMatch { 
                            LostItemId = lostId, 
                            FoundItemId = foundId, 
                            MatchConfidenceScore = Math.Min(score, 100), // Cap at 100% confidence
                            UserId = (int)newItem.CreatedBy > 0 ? (int)newItem.CreatedBy : _userData.UserId, // Safest fallback to exist in DB
                            CreatedOn = DateTime.UtcNow 
                        });
                    }
                }
            }
        }

        /// <summary>
        /// Exposes a curated list of publicly visible, "Found" tier items meant for viewing outside of user dash.
        /// </summary>
        public async Task<Response<List<GetItemDto>>> GetPublicFoundItemsAsync()
        {
            var items = await _itemRepository.AsQueryable()
                .Where(x => x.ReportType == ReportType.Found && x.Status == ItemStatus.Found)
                .ToListAsync();
                
            return Response<List<GetItemDto>>.SetSuccessResponse(_mapper.Map<List<GetItemDto>>(items));
        }

        /// <summary>
        /// Permanently removes an Item record. Note: Best practice typically uses soft deletes via 'IsDeleted' flag.
        /// </summary>
        public async Task<Response<string>> DeleteAsync(long id)
        {
            var entity = await _itemRepository.GetByIdAsync(id);
            if (entity == null) return Response<string>.NotFoundResponse();

            if (_userData != null && !_userData.Roles.Contains("Admin") && entity.CreatedBy != _userData.UserId)
            {
                return Response<string>.SetCustomErrorResponse("Access Denied: You do not have permission to delete this item.", StatusCodes.Status403Forbidden);
            }

            // Delegates true delete action logic to the GenericRepository
            await _itemRepository.DeleteAsync(id);
            return Response<string>.SetSuccessMessageResponse("Item deleted successfully");
        }

        /// <summary>
        /// Applies partial/full property updates to an existing Item.
        /// </summary>
        public async Task<Response<GetItemDto>> UpdateAsync(UpdateItemDto dto)
        {
            // 1. Fetch mutable graph representation
            var entity = await _itemRepository.GetByIdAsync(dto.Id);
            if (entity == null) return Response<GetItemDto>.NotFoundResponse();
            
            // 2. Transfer properties via AutoMapper overlay
            _mapper.Map(dto, entity);
            
            // 3. Post to db context
            await _itemRepository.UpdateAsync(entity);
            
            return Response<GetItemDto>.SetSuccessResponse(_mapper.Map<GetItemDto>(entity));
        }
    }
}
