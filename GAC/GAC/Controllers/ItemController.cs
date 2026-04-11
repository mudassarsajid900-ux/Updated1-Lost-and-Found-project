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
        [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAll(int start = 0, int length = 50, string tab = "all", string? search = null) 
            => Ok(await _itemService.GetAllAsync(start, length, tab, search));

        [HttpPut("verify/{id}")]
        [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")]
        public async Task<IActionResult> Verify(long id) => Ok(await _itemService.VerifyItemAsync(id));

        [HttpPut("move-to-auction/{id}")]
        [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")]
        public async Task<IActionResult> MoveToAuction(long id) => Ok(await _itemService.MoveToAuctionAsync(id));

        [HttpGet("my-items")]
        public async Task<IActionResult> GetMyItems()
        {
            var response = await _itemService.GetMyItemsAsync();
            return response.ToHttpResult();
        }

        [HttpGet("public-found")]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public async Task<IActionResult> GetPublicFoundItems()
        {
            var response = await _itemService.GetPublicFoundItemsAsync();
            return response.ToHttpResult();
        }

        [HttpDelete(ApiConstatnts.Delete)]
        [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(long id)
        {
            var response = await _itemService.DeleteAsync(id);
            return response.ToHttpResult();
        }
    }
}
