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
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpPost(ApiConstatnts.Create)]
        public async Task<IActionResult> Create([FromForm] CreateItemDto dto)
        {
            var response = await _itemService.CreateAsync(dto);
            return response.ToHttpResult(); 
        }

        [HttpPut(ApiConstatnts.Update)]
        public async Task<IActionResult> Update([FromBody] UpdateItemDto dto)
        {
            var response = await _itemService.UpdateAsync(dto);
            return response.ToHttpResult();
        }

        [HttpGet(ApiConstatnts.GetById)]
        public async Task<IActionResult> GetById(long id)
        {
            var response = await _itemService.GetByIdAsync(id);
            return response.ToHttpResult();
        }

        [HttpGet(ApiConstatnts.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            var response = await _itemService.GetAllAsync();
            return response.ToHttpResult();
        }

        [HttpGet("my-items")]
        public async Task<IActionResult> GetMyItems()
        {
            var response = await _itemService.GetMyItemsAsync();
            return response.ToHttpResult();
        }

        [HttpDelete(ApiConstatnts.DeleteItemBy)]
        public async Task<IActionResult> Delete(long id)
        {
            var response = await _itemService.DeleteAsync(id);
            return response.ToHttpResult();
        }
    }
}
