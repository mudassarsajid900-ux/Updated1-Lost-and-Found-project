using AutoMapper;
using GAC.Application.Interfaces.Item;
using GAC.Application.Interfaces.Shared;
using GAC.Application.Services.Item.Dtos;
using GAC.Common.Responce;
using GAC.Core.Entities.ItemTypes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GAC.Application.Services.Item
{
    /// <summary>
    /// Core service governing dynamic Item Categories and their forensic field requirements.
    /// Operates heavily on behalf of administrators to structure data-capture matrices.
    /// </summary>
    public class ItemTypeService : IItemTypeService
    {
        private readonly IGenericRepository<ItemType> _itemTypeRepository;
        private readonly IGenericRepository<GAC.Core.Entities.Item.Items> _itemRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Instantiates dependencies required for Category curation.
        /// </summary>
        public ItemTypeService(IGenericRepository<ItemType> itemTypeRepository, IGenericRepository<GAC.Core.Entities.Item.Items> itemRepository, IMapper mapper)
        {
            _itemTypeRepository = itemTypeRepository;
            _itemRepository = itemRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Pulls all Active item categories, eagerly loading dynamic form properties (Fields).
        /// Used continuously by client applications to render reactive dropdowns and input schemas.
        /// </summary>
        public async Task<Response<List<GetItemTypeDto>>> GetAllAsync()
        {
            var types = await _itemTypeRepository.AsNoTracking()
                .Include(x => x.Fields)
                .ToListAsync();
                
            var dtoList = _mapper.Map<List<GetItemTypeDto>>(types);
            return Response<List<GetItemTypeDto>>.SetSuccessResponse(dtoList);
        }

        /// <summary>
        /// Persists a new categorization configuration set, effectively expanding the system's operational scope.
        /// </summary>
        public async Task<Response<long>> CreateAsync(CreateItemTypeDto dto)
        {
            try 
            {
                // Trace Mapping Initialization
                Console.WriteLine(">>> ItemTypeService: Mapping DTO to Entity...");
                var entity = _mapper.Map<ItemType>(dto);
                
                // Commit to Database
                Console.WriteLine(">>> ItemTypeService: Saving to database...");
                await _itemTypeRepository.AddAsync(entity);
                
                Console.WriteLine(">>> ItemTypeService: Successfully created category with ID: " + entity.Id);
                return Response<long>.SetSuccessResponse(entity.Id);
            }
            catch (Exception ex)
            {
                // Unhandled structural disruption safeguard
                Console.WriteLine(">>> ItemTypeService CRITICAL FAILURE: " + ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine(">>> Inner Exception: " + ex.InnerException.Message);
                }
                return Response<long>.SetCustomErrorResponse("Database architect failure: " + ex.Message, 500);
            }
        }

        /// <summary>
        /// Permanently removes a Category configuration. 
        /// Safeguarded by a constraint verification sequence checking for extant active items.
        /// </summary>
        public async Task<Response<bool>> DeleteAsync(long id)
        {
            // 1. Deletion Guard: Prevent schema fracturing if active items rely on this type.
            var hasItems = await _itemRepository.AsQueryable()
                .AnyAsync(x => x.ItemTypeId == id && (x.Status == GAC.Core.Enums.ItemStatus.Lost || x.Status == GAC.Core.Enums.ItemStatus.Found));

            if (hasItems)
            {
                // Blocks deletion natively, requiring admin remediation first.
                return Response<bool>.SetCustomErrorResponse(
                    "Cannot delete this category because it still contains active reports. Please re-categorize or resolve those items first.", 
                    Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest);
            }

            // 2. Hydrate proxy entity representation so EF Core handles cascading removals
            var entityToDelete = await _itemTypeRepository.AsQueryable()
                .Include(x => x.Fields)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (entityToDelete != null)
            {
                await _itemTypeRepository.DeleteAsync(id);
            }
            return Response<bool>.SetSuccessResponse(true);
        }
    }
}
