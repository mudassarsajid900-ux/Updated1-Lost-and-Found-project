using GAC.Application.Interfaces.Identity;
using GAC.Application.Services.Identity.Dtos.Role;
using Microsoft.AspNetCore.Mvc;

namespace GAC.API.Controllers
{
    [ApiController]
    [Route("api/roles")]
    //[Authorize(Roles = "SuperAdmin")]
    public class RolesController : ControllerBase
    {
        private readonly IRolesService _rolesService;

        public RolesController(IRolesService rolesService)
        {
            _rolesService = rolesService;
        }

        [HttpGet("GetAllRoles")]
        public async Task<ActionResult<IEnumerable<RoleDto>>> GetAllRoles()
        {
            var roles = await _rolesService.GetAllRolesAsync();
            return Ok(roles);
        }

        [HttpGet("GetRoleById/{id:int}")]
        public async Task<ActionResult<RoleDto>> GetRoleById(int id)
        {
            var role = await _rolesService.GetRoleByIdAsync(id);
            return Ok(role);
        }

        [HttpPost("CreateRole")]
        //[Authorize(Roles = "SuperAdmin")]
        public async Task<ActionResult<RoleDto>> CreateRole([FromBody] CreateRoleDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var createdRole = await _rolesService.CreateRoleAsync(dto);

            return CreatedAtAction(nameof(GetRoleById), new { id = createdRole.Id }, createdRole);
        }

        [HttpPut("UpdateRole/{id:int}")]
        public async Task<ActionResult<RoleDto>> UpdateRole(int id, [FromBody] UpdateRoleDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var updatedRole = await _rolesService.UpdateRoleAsync(id, dto);
            return Ok(updatedRole);
        }

        [HttpDelete("DeleteRole/{id:int}")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            await _rolesService.DeleteRoleAsync(id);
            return NoContent();
        }

        [HttpPost("AssignRoleToUser")]
        public async Task<IActionResult> AssignRoleToUser([FromBody] AssignRoleToUserDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _rolesService.AssignRolesToUserAsync(dto.UserId, dto.RoleNames);
            return Ok(new { message = $"Roles '{string.Join(", ", dto.RoleNames ?? new List<string>())}' assigned to user {dto.UserId} successfully." });
        }
    }
}
