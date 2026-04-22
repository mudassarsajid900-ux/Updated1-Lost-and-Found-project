using GAC.Application.Extensions;
using GAC.Application.Interfaces.Item;
using GAC.Application.Services.Item.Dtos;
using GAC.Common.Constants;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GAC.API.Controllers
{
    /// <summary>
    /// Controller handling operations related to dynamic Item Categories/Types.
    /// Manages the configuration of custom fields required for different item reports.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class ItemTypeController : ControllerBase
    {
        private readonly IItemTypeService _itemTypeService;

        /// <summary>
        /// Initializes the controller with the necessary category service instance.
        /// </summary>
        public ItemTypeController(IItemTypeService itemTypeService)
        {
            _itemTypeService = itemTypeService;
        }

        /// <summary>
        /// Retrieves all active item categories along with their dynamically configured forensic fields.
        /// Publicly accessible to authenticated users for dropdown population.
        /// </summary>
        [HttpGet(ApiConstatnts.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            var response = await _itemTypeService.GetAllAsync();
            return response.ToHttpResult();
        }

        /// <summary>
        /// Creates a new Item Category and its required dynamic fields. 
        /// Restricted to system administrators to prevent schema fragmentation.
        /// </summary>
        [HttpPost("create")]
        [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromBody] CreateItemTypeDto dto)
        {
            // Log creation initiation for audit and debugging
            Console.WriteLine(">>> ItemTypeController: Create request received.");
            Console.WriteLine($">>> Category Name: {dto.Name}, Fields Count: {dto.Fields?.Count ?? 0}");
            
            // Delegate persistence and domain validation to service layer
            var response = await _itemTypeService.CreateAsync(dto);
            
            // Log response status before returning to client
            Console.WriteLine($">>> ItemTypeController: Service response isSucceeded: {response.IsSucceeded}");
            return response.ToHttpResult();
        }

        /// <summary>
        /// Deletes an Item Category. Note: Ensure dependent items are handled via DB constraints or cascading logic.
        /// </summary>
        [HttpDelete("{id}")]
        [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(long id)
        {
            var response = await _itemTypeService.DeleteAsync(id);
            return response.ToHttpResult();
        }
    }
}
