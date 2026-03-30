using GAC.Application.Extensions;
using GAC.Application.Interfaces.Item;
using GAC.Application.Services.Item.Dtos;
using GAC.Common.Constants;
using Microsoft.AspNetCore.Mvc;

namespace GAC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class ItemTypeController : ControllerBase
    {
        private readonly IItemTypeService _itemTypeService;

        public ItemTypeController(IItemTypeService itemTypeService)
        {
            _itemTypeService = itemTypeService;
        }

        [HttpGet(ApiConstatnts.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            var response = await _itemTypeService.GetAllAsync();
            return response.ToHttpResult();
        }

        [HttpPost("create")]
        [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromBody] CreateItemTypeDto dto)
        {
            var response = await _itemTypeService.CreateAsync(dto);
            return response.ToHttpResult();
        }

        [HttpDelete("{id}")]
        [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(long id)
        {
            var response = await _itemTypeService.DeleteAsync(id);
            return response.ToHttpResult();
        }
    }
}
