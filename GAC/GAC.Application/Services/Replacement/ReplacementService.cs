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

namespace GAC.Application.Services.Replacement
{
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

        public async Task<Response<GetReplacementDto>> CreateReplacementAsync(CreateReplacementDto dto)
        {
            // Verify item eligibility
            var item = await _itemRepository.GetByIdAsync((int)dto.LostItemId);
            if (item == null || item.ReportType != ReportType.Lost || item.CreatedBy != _userData.UserId)
                return Response<GetReplacementDto>.NotFoundResponse();

            if (item.Status == ItemStatus.Replacement || item.Status == ItemStatus.ReplacementHandover)
                return Response<GetReplacementDto>.SetCustomErrorResponse("This item is already in the replacement process.", StatusCodes.Status400BadRequest);

            var thresholdDays = await GetReplacementThresholdAsync();
            if ((DateTime.UtcNow - item.EventTime.ToUniversalTime()).TotalDays < thresholdDays)
                return Response<GetReplacementDto>.SetCustomErrorResponse($"You must wait at least {thresholdDays} days before requesting a replacement.", StatusCodes.Status400BadRequest);

            var entity = _mapper.Map<ReplacementRecord>(dto);
            entity.Status = ReplacementStatus.Pending;

            await _replacementRepository.AddAsync(entity);

            // Update item status
            item.Status = ItemStatus.Replacement;
            await _itemRepository.UpdateAsync(item);

            var result = _mapper.Map<GetReplacementDto>(entity);
            return Response<GetReplacementDto>.SetSuccessResponse(result, "Replacement request submitted successfully.", StatusCodes.Status201Created);
        }

        public async Task<Response<List<ReplacementEligibleItemDto>>> GetEligibleItemsAsync()
        {
            var thresholdDays = await GetReplacementThresholdAsync();
            var cutoffDate = DateTime.UtcNow.AddDays(-thresholdDays);

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

        public async Task<Response<GetReplacementDto>> GetByIdAsync(long id)
        {
            var entity = await _replacementRepository.AsQueryable()
                .Include(x => x.LostItem).ThenInclude(i => i.ItemType)
                .Include(x => x.FoundItem).ThenInclude(i => i.ItemType)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null)
                return Response<GetReplacementDto>.NotFoundResponse();

            var result = _mapper.Map<GetReplacementDto>(entity);
            return Response<GetReplacementDto>.SetSuccessResponse(result);
        }

        public async Task<Response<List<GetReplacementDto>>> GetMyReplacementsAsync()
        {
            var records = await _replacementRepository.AsQueryable()
                .Include(x => x.LostItem).ThenInclude(i => i.Location)
                .Include(x => x.LostItem).ThenInclude(i => i.ItemType)
                .Include(x => x.FoundItem).ThenInclude(i => i.Location)
                .Include(x => x.FoundItem).ThenInclude(i => i.ItemType)
                .Where(x => x.CreatedBy == _userData.UserId)
                .ToListAsync();

            var result = _mapper.Map<List<GetReplacementDto>>(records);
            return Response<List<GetReplacementDto>>.SetSuccessResponse(result);
        }

        public async Task<Response<List<GetReplacementDto>>> GetAllPendingRequestsAsync()
        {
            var records = await _replacementRepository.AsQueryable()
                .Include(x => x.LostItem).ThenInclude(i => i.ItemType)
                .Where(x => x.Status == ReplacementStatus.Pending || x.Status == ReplacementStatus.UnderReview)
                .ToListAsync();

            var result = _mapper.Map<List<GetReplacementDto>>(records);
            return Response<List<GetReplacementDto>>.SetSuccessResponse(result);
        }

        public async Task<Response<GetReplacementDto>> ProcessRequestAsync(AdminProcessReplacementDto dto)
        {
            var request = await _replacementRepository.AsQueryable()
                .Include(x => x.LostItem)
                .FirstOrDefaultAsync(x => x.Id == dto.RequestId);

            if (request == null)
                return Response<GetReplacementDto>.NotFoundResponse();

            if (dto.IsApproved)
            {
                var foundItem = await _itemRepository.GetByIdAsync((int)dto.FoundItemId);
                if (foundItem == null || foundItem.ReportType != ReportType.Found || foundItem.Status != ItemStatus.Found)
                    return Response<GetReplacementDto>.SetCustomErrorResponse("Selected found item is not available for replacement.", StatusCodes.Status400BadRequest);

                request.Status = ReplacementStatus.Approved;
                request.FoundItemId = dto.FoundItemId;
                request.LostItem.Status = ItemStatus.ReplacementHandover; // Ready for collection
                
                foundItem.Status = ItemStatus.Handover; // Reserved for this user
                await _itemRepository.UpdateAsync(foundItem);
            }
            else
            {
                request.Status = ReplacementStatus.Rejected;
                request.LostItem.Status = ItemStatus.Lost; // Back to lost pool
            }

            request.AdminNotes = dto.AdminNotes;
            request.DecisionDate = DateTime.UtcNow;

            await _replacementRepository.UpdateAsync(request);
            await _itemRepository.UpdateAsync(request.LostItem);

            var result = _mapper.Map<GetReplacementDto>(request);
            return Response<GetReplacementDto>.SetSuccessResponse(result, dto.IsApproved ? "Request approved." : "Request rejected.");
        }

        public async Task<Response<List<long>>> GetSmartMatchSuggestionsAsync(long requestId)
        {
            var request = await _replacementRepository.AsQueryable()
                .Include(x => x.LostItem)
                .FirstOrDefaultAsync(x => x.Id == requestId);

            if (request == null)
                return Response<List<long>>.NotFoundResponse();

            // Smart logic: Unclaimed items of the same type
            var suggestions = await _itemRepository.AsQueryable()
                .Where(x => x.ReportType == ReportType.Found && 
                           x.Status == ItemStatus.Found && 
                           x.ItemTypeId == request.LostItem.ItemTypeId)
                .OrderBy(x => x.EventTime) // Oldest first (priority logic)
                .Select(x => x.Id)
                .Take(5)
                .ToListAsync();

            return Response<List<long>>.SetSuccessResponse(suggestions);
        }

        public async Task<Response<bool>> UpdateThresholdAsync(int days)
        {
            var setting = await _settingsRepository.AsQueryable()
                .FirstOrDefaultAsync(x => x.SettingKey == "ReplacementThresholdDays");

            if (setting == null)
            {
                setting = new SystemSetting
                {
                    SettingKey = "ReplacementThresholdDays",
                    SettingValue = days.ToString(),
                    Description = "Number of days a lost item remains missing before replacement eligibility opens.",
                    CreatedBy = _userData.UserId
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

            return Response<bool>.SetSuccessResponse(true, "Replacement threshold updated successfully.");
        }

        private async Task<int> GetReplacementThresholdAsync()
        {
            var setting = await _settingsRepository.AsQueryable()
                .FirstOrDefaultAsync(x => x.SettingKey == "ReplacementThresholdDays");
            
            if (setting != null && int.TryParse(setting.SettingValue, out int days))
                return days;

            return 90; // Default
        }
    }
}
