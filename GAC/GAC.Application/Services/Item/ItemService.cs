using AutoMapper;
using GAC.Application.Helper;
using GAC.Application.Interfaces.Item;
using GAC.Application.Interfaces.Shared;
using GAC.Application.Services.Item.Dtos;
using GAC.Common.Responce;
using GAC.Core.Entities.Item;
using GAC.Core.Entities.ItemTypes;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.IO;

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

        public ItemService(
            IGenericRepository<Items> itemRepository,
            IGenericRepository<ItemAttribute> attributeRepository,
            IMapper mapper,
            UserData userData,
            IWebHostEnvironment environment,
            IGenericRepository<ItemMatch> itemMatchRepository)
        {
            _itemRepository = itemRepository;
            _attributeRepository = attributeRepository;
            _mapper = mapper;
            _userData = userData;
            _environment = environment;
            _itemMatchRepository = itemMatchRepository;
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

                // Run matching algorithm for new Found item
                await CheckForMatchesAsync(entity);

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

                // Run matching algorithm for new Lost item
                await CheckForMatchesAsync(entity);

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
            var existing = await _itemRepository
                .AsNoTracking()
                .Include(x=>x.Attributes)
                .Include(x => x.Location)
                .FirstOrDefaultAsync(x=>x.Id==dto.Id);

            if (existing == null)
                return Response<GetItemDto>.NotFoundResponse();

            _mapper.Map(dto, existing);

            // Remove old attributes
            if (existing.Attributes != null && existing.Attributes.Any())
                await _attributeRepository.DeleteListAsync(existing.Attributes.ToList());

            // Add new attributes
            existing.Attributes = dto.Attributes?.Select(a => new ItemAttribute
            {
                FieldName = a.FieldName,
                FieldValue = a.FieldValue,
                LostItemId = existing.Id
            }).ToList();

            await _itemRepository.UpdateAsync(existing);

            var updated = await GetByIdAsync(existing.Id);

            return Response<GetItemDto>.SetSuccessResponse(
                updated.Data,
                "Lost Report submitted successfully");
        }

        public async Task<Response<GetItemDto>> GetByIdAsync(long id)
        {
            var entity = await _itemRepository
                .AsNoTracking()
                .Include(x => x.Attributes)
                .Include(x => x.Location)
                .Include(x => x.ItemType)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (entity == null)
                return Response<GetItemDto>.NotFoundResponse();

            var dto = _mapper.Map<GetItemDto>(entity);

            return Response<GetItemDto>.SetSuccessResponse(dto);
        }


        public async Task<Response<List<GetItemDto>>> GetAllAsync()
        {
            var items = await _itemRepository.AsQueryable()
                .Include(x => x.Location)
                .Include(x => x.ItemType)
                .Include(x => x.Attributes)
                .ToListAsync();

            var dtoList = _mapper.Map<List<GetItemDto>>(items);

            return Response<List<GetItemDto>>.SetSuccessResponse(dtoList);
        }

        /// <summary>
        /// Returns all reports submitted by the currently logged-in user.
        /// </summary>
        public async Task<Response<List<GetItemDto>>> GetMyItemsAsync()
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

            // Fetch any potential matches for the user's lost items
            var userItemIds = items.Select(x => x.Id).ToList();
            var matches = await _itemMatchRepository.AsQueryable()
                .Where(m => userItemIds.Contains(m.LostItemId) && !m.IsMatchResolved)
                .ToListAsync();

            foreach(var dto in dtoList)
            {
                var match = matches.FirstOrDefault(m => m.LostItemId == dto.Id);
                if (match != null)
                {
                    dto.HasPotentialMatch = true;
                    dto.MatchFoundItemId = match.FoundItemId;
                }
            }

            return Response<List<GetItemDto>>.SetSuccessResponse(dtoList);
        }

        public async Task<Response<string>> DeleteAsync(long id)
        {
            var entity = await _itemRepository.GetByIdAsync((int)id);

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
                .Where(x => x.ReportType == targetType && x.ItemTypeId == newItem.ItemTypeId && x.Status != GAC.Core.Enums.ItemStatus.Handover)
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
    }
}
