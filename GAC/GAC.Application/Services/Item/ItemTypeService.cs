// ========================================== //
// SECTION: CATEGORY ARCHITECT SERVICES
// DESCRIPTION: Dynamic schema management for Forensic Attributes and Asset Types.
// ========================================== //
using AutoMapper;
using GAC.Application.Interfaces.Item;
using GAC.Application.Interfaces.Shared;
using GAC.Application.Services.Item.Dtos;
using GAC.Common.Responce;
using GAC.Core.Entities.ItemTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GAC.Application.Services.Item
{
    /// <summary>
    /// The ItemTypeService implements the 'Architect Sync' protocol.
    /// It allows administrators to define the structure of reports in real-time by adding
    /// new categories and their corresponding forensic field requirements.
    /// </summary>
    public class ItemTypeService : IItemTypeService
    {
        private readonly IGenericRepository<ItemType> _itemTypeRepository;
        private readonly IGenericRepository<GAC.Core.Entities.Item.Items> _itemRepository;
        private readonly IMapper _mapper;

        public ItemTypeService(
            IGenericRepository<ItemType> itemTypeRepository, 
            IGenericRepository<GAC.Core.Entities.Item.Items> itemRepository, 
            IMapper mapper)
        {
            _itemTypeRepository = itemTypeRepository;
            _itemRepository = itemRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Retrieves all item categories including their dynamic forensic attribute definitions.
        /// Consumed by the frontend to render dynamic reporting forms.
        /// </summary>
        public async Task<Response<List<GetItemTypeDto>>> GetAllAsync()
        {
            var types = await _itemTypeRepository.AsNoTracking()
                .Include(x => x.Fields) 
                .ToListAsync();

            return Response<List<GetItemTypeDto>>.SetSuccessResponse(_mapper.Map<List<GetItemTypeDto>>(types));
        }

        /// <summary>
        /// Provisioning: Registers a new category archetype.
        /// Once active, the matching engine automatically supports this new asset class.
        /// </summary>
        public async Task<Response<long>> CreateAsync(CreateItemTypeDto dto)
        {
            // Integrity: Ensure no duplicate forensic keys exist within the same category
            if (dto.Fields != null && dto.Fields.Select(f => f.FieldName.ToLower().Trim()).Distinct().Count() != dto.Fields.Count)
            {
                return Response<long>.SetCustomErrorResponse(
                    "Provisioning Error: Duplicate attribute keys detected. Each forensic field must be unique.", 
                    StatusCodes.Status400BadRequest);
            }

            var entity = _mapper.Map<ItemType>(dto);
            entity.CreatedOn = DateTime.UtcNow;
            
            await _itemTypeRepository.AddAsync(entity);
            return Response<long>.SetSuccessResponse(entity.Id, "Category provisioned successfully.");
        }

        /// <summary>
        /// Updates an archetype using the 'Wipe-and-Rebuild' sync pattern for forensic fields.
        /// This ensures the database exactly matches the administrator's UI configuration.
        /// </summary>
        public async Task<Response<bool>> UpdateAsync(UpdateItemTypeDto dto)
        {
            var type = await _itemTypeRepository.AsQueryable()
                .Include(x => x.Fields)
                .FirstOrDefaultAsync(x => x.Id == dto.Id);

            if (type == null) return Response<bool>.NotFoundResponse();

            // Guard: Identity and Field uniqueness
            if (dto.Fields != null && dto.Fields.Select(f => f.FieldName.ToLower().Trim()).Distinct().Count() != dto.Fields.Count)
            {
                return Response<bool>.SetCustomErrorResponse(
                    "Sync Error: Category update rejected due to duplicate attribute keys.", 
                    StatusCodes.Status400BadRequest);
            }

            type.Name = dto.Name;
            type.LastModifiedOn = DateTime.UtcNow;

            // Smart Forensic Sync Protocol:
            // We reconcile fields by name to ensure absolute data integrity.
            // 1. Identify which fields are being REMOVED in the new configuration
            var fieldsToRemove = type.Fields
                .Where(existingField => !dto.Fields.Any(newField => newField.FieldName.Trim().Equals(existingField.FieldName, StringComparison.OrdinalIgnoreCase)))
                .ToList();

            foreach (var field in fieldsToRemove)
            {
                type.Fields.Remove(field);
            }

            // 2. Add or Update fields based on the new schema snapshot
            foreach (var updateDto in dto.Fields ?? new List<CreateFieldDto>())
            {
                var trimmedName = updateDto.FieldName.Trim();
                var existingField = type.Fields
                    .FirstOrDefault(f => f.FieldName.Equals(trimmedName, StringComparison.OrdinalIgnoreCase));

                if (existingField == null)
                {
                    // New asset archetype field detected: Provisioning
                    type.Fields.Add(new Fields { FieldName = trimmedName });
                }
                // If it exists, we preserve it (ID remains the same, protecting report links)
            }

            await _itemTypeRepository.UpdateAsync(type);
            return Response<bool>.SetSuccessResponse(true, "Category architecture synchronized safely.");
        }

        /// <summary>
        /// Safely decommissions an item category.
        /// Logic Guard: Prevents deletion if any reports (Lost/Found) are currently tethered to this archetype.
        /// </summary>
        public async Task<Response<bool>> DeleteAsync(long id)
        {
            // Dependency Check: Audit current inventory for usage of this category
            var usageCount = await _itemRepository.AsQueryable()
                .CountAsync(x => x.ItemTypeId == id && (x.Status == GAC.Core.Enums.ItemStatus.Lost || x.Status == GAC.Core.Enums.ItemStatus.Found));

            if (usageCount > 0)
            {
                return Response<bool>.SetCustomErrorResponse(
                    $"Decommissioning Blocked: Found {usageCount} active reports using this category. Re-categorize items before deletion.", 
                    StatusCodes.Status400BadRequest);
            }

            await _itemTypeRepository.DeleteAsync(id);
            return Response<bool>.SetSuccessResponse(true, "Category decommissioned.");
        }
    }
}
