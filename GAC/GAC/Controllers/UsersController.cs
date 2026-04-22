using GAC.Application.Interfaces.Identity;
using GAC.Application.Services.Identity.Dtos.User;
using GAC.Common.Pagination;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GAC.API.Controllers
{
    [Authorize(Roles = "Admin")]
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserManagementService _userService;

        public UsersController(IUserManagementService userService)
        {
            _userService = userService;
        }

        [HttpPost("list")]
        public async Task<IActionResult> GetUsers([FromBody] DataTableRequest request)
        {
            var (users, total) = await _userService.GetUsersAsync(request);
            return Ok(new { result = users, recordsTotal = total, recordsFiltered = total });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var res = await _userService.GetUserByIdAsync(id);
            if (!res.IsSucceeded) return NotFound(res.Message);
            return Ok(res.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserDto dto)
        {
            var res = await _userService.CreateUserAsync(dto);
            if (!res.IsSucceeded) return BadRequest(res.Message);
            return Ok(new { message = "User created successfully" });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateUserDto dto)
        {
            if (id != dto.Id)
                return BadRequest("Id mismatch");

            var res = await _userService.UpdateUserAsync(dto);
            if (!res.IsSucceeded) return BadRequest(res.Message);

            return Ok(new { message = "User updated successfully" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var res = await _userService.DeleteUserAsync(id);
            if (!res.IsSucceeded) return BadRequest(res.Message);
            return Ok(new { message = "User deleted successfully" });
        }

        [HttpPost("{id}/remove-role")]
        public async Task<IActionResult> RemoveRole(int id, [FromQuery] string role)
        {
            var res = await _userService.RemoveRoleAsync(id, role);
            if (!res.IsSucceeded) return BadRequest(res.Message);
            return Ok(new { message = "Role removed successfully" });
        }

        [HttpPost("{id}/toggle-activate")]
        public async Task<IActionResult> ToggleActivate(int id)
        {
            var res = await _userService.ActivateDeactivateAsync(id);
            if (!res.IsSucceeded) return BadRequest(res.Message);
            return Ok(res.Data);
        }

        [HttpGet("{id}/roles")]
        public async Task<IActionResult> GetRoles(int id)
        {
            var res = await _userService.GetRolesByUserIdAsync(id);
            if (!res.IsSucceeded) return BadRequest(res.Message);
            return Ok(res.Data);
        }
    }
}
