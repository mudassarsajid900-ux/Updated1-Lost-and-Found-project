using AutoMapper;
using GAC.Application.Interfaces.Item;
using GAC.Application.Interfaces.Shared;
using GAC.Application.Services.Item.Dtos;
using GAC.Common.Responce;
using GAC.Core.Entities.ItemTypes;
using Microsoft.EntityFrameworkCore;

namespace GAC.Application.Services.Item
{
    public class ItemTypeService : IItemTypeService
    {
        private readonly IGenericRepository<ItemType> _itemTypeRepository;
        private readonly IGenericRepository<GAC.Core.Entities.Item.Items> _itemRepository;
        private readonly IMapper _mapper;

        public ItemTypeService(IGenericRepository<ItemType> itemTypeRepository, IGenericRepository<GAC.Core.Entities.Item.Items> itemRepository, IMapper mapper)
        {
            _itemTypeRepository = itemTypeRepository;
            _itemRepository = itemRepository;
            _mapper = mapper;
        }

        public async Task<Response<List<GetItemTypeDto>>> GetAllAsync()
        {
            var types = await _itemTypeRepository.AsNoTracking()
                .Include(x => x.Fields)
                .ToListAsync();
            var dtoList = _mapper.Map<List<GetItemTypeDto>>(types);
            return Response<List<GetItemTypeDto>>.SetSuccessResponse(dtoList);
        }

        public async Task<Response<long>> CreateAsync(CreateItemTypeDto dto)
        {
            var entity = _mapper.Map<ItemType>(dto);
            await _itemTypeRepository.AddAsync(entity);
            return Response<long>.SetSuccessResponse(entity.Id);
        }

        public async Task<Response<bool>> DeleteAsync(long id)
        {
            // Deletion Guard: Check if any items are still using this category
            var hasItems = await _itemRepository.AsQueryable()
                .AnyAsync(x => x.ItemTypeId == id && (x.Status == GAC.Core.Enums.ItemStatus.Lost || x.Status == GAC.Core.Enums.ItemStatus.Found));

            if (hasItems)
            {
                return Response<bool>.SetCustomErrorResponse(
                    "Cannot delete this category because it still contains active reports. Please re-categorize or resolve those items first.", 
                    Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest);
            }

            await _itemTypeRepository.DeleteAsync(id);
            return Response<bool>.SetSuccessResponse(true);
        }
    }
}
