// ========================================== //
// SECTION: REPLACEMENT & COMPENSATION SERVICES
// DESCRIPTION: Facilitates asset replacement for long-term missing items.
// ========================================== //
using AutoMapper;
using GAC.Application.Helper;
using GAC.Application.Interfaces.Replacement;
using GAC.Application.Interfaces.Shared;
using GAC.Application.Services.Replacement.Dtos;
using GAC.Common.Responce;
using GAC.Core.Entities.Item;
using GAC.Core.Entities.Replacement;
using GAC.Core.Entities.SystemSettings;
using GAC.Core.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GAC.Application.Services.Replacement
{
    /// <summary>
    /// The ReplacementService manages the 'Insurance/Compensation' workflow.
    /// It allows students with long-term unrecovered lost items to request 
    /// a comparable replacement from the unclaimed found item pool, 
    /// subject to eligibility thresholds.
    /// </summary>
    public class ReplacementService : IReplacementService
    {
        private readonly IGenericRepository<ReplacementRecord> _replacementRepository;
        private readonly IGenericRepository<Items> _itemRepository;
        private readonly IGenericRepository<SystemSetting> _settingsRepository;
        private readonly IMapper _mapper;
        private readonly UserData _userData;

        public ReplacementService(
            IGenericRepository<ReplacementRecord> replacementRepository,
            IGenericRepository<Items> itemRepository,
            IGenericRepository<SystemSetting> settingsRepository,
            IMapper mapper,
            UserData userData)
        {
            _replacementRepository = replacementRepository;
            _itemRepository = itemRepository;
            _settingsRepository = settingsRepository;
            _mapper = mapper;
            _userData = userData;
        }

        /// <summary>
        /// Registers a new replacement request for a lost item.
        /// Validates temporal eligibility (e.g., must be missing for 90 days).
        /// </summary>
        /// <param name="dto">The lost item reference for which replacement is sought.</param>
        public async Task<Response<GetReplacementDto>> CreateReplacementAsync(CreateReplacementDto dto)
        {
            // Identity & Type Guard
            var item = await _itemRepository.GetByIdAsync(dto.LostItemId);
            if (item == null || item.ReportType != ReportType.Lost || item.CreatedBy != _userData.UserId)
                return Response<GetReplacementDto>.NotFoundResponse();

            // Status Guard
            if (item.Status != ItemStatus.Lost)
                return Response<GetReplacementDto>.SetCustomErrorResponse("Eligibility Error: Asset must be in 'Lost' status.", StatusCodes.Status400BadRequest);

            // Temporal Guard: Enforce wait period to allow natural recovery/matching
            var thresholdDays = await GetSettingValueAsync("ReplacementEligibilityThreshold", 90);
            if (thresholdDays > 0 && (DateTime.UtcNow - item.EventTime.ToUniversalTime()).TotalDays < thresholdDays)
                return Response<GetReplacementDto>.SetCustomErrorResponse($"Eligibility Error: Mandatory {thresholdDays}-day waiting period not met.", StatusCodes.Status400BadRequest);

            var entity = _mapper.Map<ReplacementRecord>(dto);
            entity.Status = ReplacementStatus.Pending;
            entity.CreatedBy = _userData.UserId;
            entity.CreatedOn = DateTime.UtcNow;

            await _replacementRepository.AddAsync(entity);

            // Item Lifecycle: Transition to 'Replacement' state to prevent duplicate requests
            item.Status = ItemStatus.Replacement;
            item.LastModifiedOn = DateTime.UtcNow;
            await _itemRepository.UpdateAsync(item);

            var result = _mapper.Map<GetReplacementDto>(entity);
            return Response<GetReplacementDto>.SetSuccessResponse(result, "Success: Replacement request is now in the review queue.", StatusCodes.Status201Created);
        }

        /// <summary>
        /// Fetches all lost items belonging to the user that have passed the eligibility threshold.
        /// </summary>
        public async Task<Response<List<ReplacementEligibleItemDto>>> GetEligibleItemsAsync()
        {
            var thresholdDays = await GetSettingValueAsync("ReplacementEligibilityThreshold", 90);
            var cutoffDate = thresholdDays == 0 ? DateTime.UtcNow.AddYears(1) : DateTime.UtcNow.AddDays(-thresholdDays);

            var items = await _itemRepository.AsQueryable()
                .Include(x => x.ItemType)
                .Where(x => x.CreatedBy == _userData.UserId && 
                           x.ReportType == ReportType.Lost && 
                           x.Status == ItemStatus.Lost &&
                           x.EventTime <= cutoffDate)
                .ToListAsync();

            var result = items.Select(x => new ReplacementEligibleItemDto
            {
                Id = x.Id,
                Title = x.ItemType.Name,
                ReportedDate = x.EventTime,
                DaysSinceReported = (int)(DateTime.UtcNow - x.EventTime.ToUniversalTime()).TotalDays,
                IsEligible = true
            }).ToList();

            return Response<List<ReplacementEligibleItemDto>>.SetSuccessResponse(result);
        }

        /// <summary>
        /// Securely retrieves a specific replacement record with ownership validation.
        /// </summary>
        public async Task<Response<GetReplacementDto>> GetByIdAsync(long id)
        {
            var entity = await _replacementRepository.AsQueryable()
                .Include(x => x.LostItem).ThenInclude(i => i.ItemType)
                .Include(x => x.FoundItem).ThenInclude(i => i.ItemType)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null) return Response<GetReplacementDto>.NotFoundResponse();

            // Security: Restrict detailed view to Owner or Admin
            if (_userData != null && !_userData.Roles.Contains("Admin") && entity.CreatedBy != _userData.UserId)
            {
                return Response<GetReplacementDto>.SetCustomErrorResponse("Unauthorized: Access to this record is restricted.", StatusCodes.Status403Forbidden);
            }

            return Response<GetReplacementDto>.SetSuccessResponse(_mapper.Map<GetReplacementDto>(entity));
        }

        public async Task<Response<List<GetReplacementDto>>> GetMyReplacementsAsync()
        {
            var records = await _replacementRepository.AsQueryable()
                .Include(x => x.LostItem).ThenInclude(i => i.Location).Include(x => x.LostItem).ThenInclude(i => i.ItemType)
                .Include(x => x.FoundItem).ThenInclude(i => i.Location).Include(x => x.FoundItem).ThenInclude(i => i.ItemType)
                .Where(x => x.CreatedBy == _userData.UserId)
                .ToListAsync();

            return Response<List<GetReplacementDto>>.SetSuccessResponse(_mapper.Map<List<GetReplacementDto>>(records));
        }

        /// <summary>
        /// Admin Engine: Fetches all requests awaiting manual triage.
        /// </summary>
        public async Task<Response<List<GetReplacementDto>>> GetAllPendingRequestsAsync()
        {
            var records = await _replacementRepository.AsQueryable()
                .Include(x => x.LostItem).ThenInclude(i => i.ItemType)
                .Include(x => x.LostItem).ThenInclude(i => i.CreatedByUser)
                .Where(x => x.Status == ReplacementStatus.Pending || x.Status == ReplacementStatus.UnderReview)
                .ToListAsync();

            return Response<List<GetReplacementDto>>.SetSuccessResponse(_mapper.Map<List<GetReplacementDto>>(records));
        }

        /// <summary>
        /// Finalizes a replacement request.
        /// Orchestrates the handover reservation for the found item and the archival of the lost item.
        /// </summary>
        public async Task<Response<GetReplacementDto>> ProcessRequestAsync(AdminProcessReplacementDto dto)
        {
            var request = await _replacementRepository.AsQueryable()
                .Include(x => x.LostItem)
                .FirstOrDefaultAsync(x => x.Id == dto.RequestId);

            if (request == null) return Response<GetReplacementDto>.NotFoundResponse();

            if (dto.IsApproved && dto.FoundItemId.HasValue)
            {
                var foundItem = await _itemRepository.GetByIdAsync(dto.FoundItemId.Value);
                if (foundItem == null || foundItem.ReportType != ReportType.Found || (foundItem.Status != ItemStatus.Found && foundItem.Status != ItemStatus.Replacement))
                    return Response<GetReplacementDto>.SetCustomErrorResponse("Inventory Error: Target found item is no longer available.", StatusCodes.Status400BadRequest);

                request.Status = ReplacementStatus.Approved;
                request.FoundItemId = dto.FoundItemId;
                request.LostItem.Status = ItemStatus.ReplacementHandover; 
                
                // Reserve the found asset for this user's collection
                foundItem.Status = ItemStatus.Handover; 
                foundItem.LastModifiedOn = DateTime.UtcNow;
                await _itemRepository.UpdateAsync(foundItem);
            }
            else
            {
                request.Status = ReplacementStatus.Rejected;
                request.LostItem.Status = ItemStatus.Lost; // Return to general lost pool for future matching
            }

            request.AdminNotes = dto.AdminNotes;
            request.DecisionDate = DateTime.UtcNow;
            request.LastModifiedOn = DateTime.UtcNow;

            await _replacementRepository.UpdateAsync(request);
            await _itemRepository.UpdateAsync(request.LostItem);

            var result = _mapper.Map<GetReplacementDto>(request);
            return Response<GetReplacementDto>.SetSuccessResponse(result, dto.IsApproved ? "Request Approved: Notification dispatched." : "Request Rejected.");
        }

        /// <summary>
        /// The Replacement Intelligent Suggestion Engine:
        /// Scans the unclaimed found inventory for the closest matches using weighted attributes (20pts/attribute).
        /// Only considers items physically verified and present in the admin office.
        /// </summary>
        public async Task<Response<List<long>>> GetSmartMatchSuggestionsAsync(long requestId)
        {
            var request = await _replacementRepository.AsQueryable()
                .Include(x => x.LostItem).ThenInclude(i => i.Attributes)
                .FirstOrDefaultAsync(x => x.Id == requestId);

            if (request == null) return Response<List<long>>.NotFoundResponse();

            // 1. Filter: Same Category + Verified Physical Presence + Availability
            var candidates = await _itemRepository.AsQueryable()
                .Include(x => x.Attributes)
                .Where(x => x.ReportType == ReportType.Found && 
                           x.IsVerifiedByAdmin == true && 
                           (x.Status == ItemStatus.Found || x.Status == ItemStatus.Replacement) && 
                           x.ItemTypeId == request.LostItem.ItemTypeId)
                .OrderBy(x => x.EventTime)
                .Take(20)
                .ToListAsync();

            if (!candidates.Any()) return Response<List<long>>.SetSuccessResponse(new List<long>());

            // 2. Score: Weighted attribute comparison for similarity ranking
            var scoredSuggestions = candidates.Select(c => {
                int score = 0;
                foreach (var lostAttr in request.LostItem.Attributes)
                {
                    if (c.Attributes.Any(ca => 
                        ca.FieldName.Equals(lostAttr.FieldName, StringComparison.OrdinalIgnoreCase) && 
                        ca.FieldValue.Equals(lostAttr.FieldValue, StringComparison.OrdinalIgnoreCase)))
                    {
                        score += 20; 
                    }
                }
                return new { ItemId = c.Id, Score = score };
            })
            .OrderByDescending(x => x.Score)
            .ThenBy(x => x.ItemId)
            .Take(5)
            .Select(x => x.ItemId)
            .ToList();

            return Response<List<long>>.SetSuccessResponse(scoredSuggestions);
        }

        public async Task<Response<bool>> UpdateReplacementEligibilityThresholdAsync(int days)
        {
            return await UpsertSettingAsync("ReplacementEligibilityThreshold", days, 
                "Wait period (days) before a lost report can initiate a replacement claim.");
        }

        public async Task<Response<bool>> UpdateFoundToReplacementThresholdAsync(int days)
        {
            return await UpsertSettingAsync("FoundToReplacementThreshold", days, 
                "Retention period (days) before an unclaimed found item enters the replacement pool.");
        }

        public async Task<Response<bool>> UpdateReplacementToAuctionThresholdAsync(int days)
        {
            return await UpsertSettingAsync("ReplacementToAuctionThreshold", days, 
                "Time limit (days) for items in the replacement pool before liquidation via auction.");
        }

        public async Task<Response<Dictionary<string, int>>> GetAllThresholdsAsync()
        {
            var result = new Dictionary<string, int>
            {
                { "ReplacementEligibilityThreshold", await GetSettingValueAsync("ReplacementEligibilityThreshold", 90) },
                { "FoundToReplacementThreshold", await GetSettingValueAsync("FoundToReplacementThreshold", 20) },
                { "ReplacementToAuctionThreshold", await GetSettingValueAsync("ReplacementToAuctionThreshold", 40) }
            };

            return Response<Dictionary<string, int>>.SetSuccessResponse(result);
        }

        /// <summary>
        /// Retrieves the current available inventory of found items staged for replacement allocation.
        /// </summary>
        public async Task<Response<List<ReplacementPoolItemDto>>> GetAvailablePoolItemsAsync()
        {
            var items = await _itemRepository.AsQueryable()
                .Include(x => x.ItemType).Include(x => x.Location)
                .Where(x => x.Status == ItemStatus.Replacement && 
                           x.ReportType == ReportType.Found &&
                           x.IsVerifiedByAdmin == true)
                .ToListAsync();

            var result = items.Select(x => new ReplacementPoolItemDto
            {
                Id = x.Id, Title = x.ItemType.Name, ImageUrl = x.ImageUrl, FoundDate = x.CreatedOn,
                Location = x.Location?.Name ?? "General Campus",
                DaysInPool = (int)(DateTime.UtcNow - x.LastModifiedOn.ToUniversalTime()).TotalDays
            }).ToList();

            return Response<List<ReplacementPoolItemDto>>.SetSuccessResponse(result);
        }

        private async Task<Response<bool>> UpsertSettingAsync(string key, int days, string description)
        {
            var setting = await _settingsRepository.AsQueryable()
                .OrderByDescending(x => x.CreatedOn)
                .FirstOrDefaultAsync(x => x.SettingKey == key);

            if (setting == null)
            {
                setting = new SystemSetting {
                    SettingKey = key, SettingValue = days.ToString(), Description = description,
                    CreatedBy = _userData.UserId, CreatedOn = DateTime.UtcNow
                };
                await _settingsRepository.AddAsync(setting);
            }
            else
            {
                setting.SettingValue = days.ToString();
                setting.LastModifiedBy = _userData.UserId;
                setting.LastModifiedOn = DateTime.UtcNow;
                await _settingsRepository.UpdateAsync(setting);
            }

            return Response<bool>.SetSuccessResponse(true, $"System Config Synchronized: {key} updated.");
        }

        private async Task<int> GetSettingValueAsync(string key, int defaultValue)
        {
            var setting = await _settingsRepository.AsQueryable()
                .OrderByDescending(x => x.CreatedOn)
                .FirstOrDefaultAsync(x => x.SettingKey == key);
            
            if (setting != null && int.TryParse(setting.SettingValue, out int days))
                return days;

            return defaultValue;
        }
    }
}
