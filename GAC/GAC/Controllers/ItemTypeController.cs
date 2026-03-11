using GAC.Application.Extensions;
using GAC.Application.Interfaces.Item;
using GAC.Common.Constants;
using Microsoft.AspNetCore.Mvc;

namespace GAC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
    }
}
