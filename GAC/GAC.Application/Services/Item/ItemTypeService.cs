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
        private readonly IMapper _mapper;

        public ItemTypeService(IGenericRepository<ItemType> itemTypeRepository, IMapper mapper)
        {
            _itemTypeRepository = itemTypeRepository;
            _mapper = mapper;
        }

        public async Task<Response<List<GetItemTypeDto>>> GetAllAsync()
        {
            var types = await _itemTypeRepository.AsNoTracking().ToListAsync();
            var dtoList = _mapper.Map<List<GetItemTypeDto>>(types);
            return Response<List<GetItemTypeDto>>.SetSuccessResponse(dtoList);
        }
    }
}
