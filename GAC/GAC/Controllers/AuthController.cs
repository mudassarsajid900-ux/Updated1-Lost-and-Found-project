using GAC.Application.Interfaces.Identity;
using GAC.Application.Services.Identity.Dtos.Auth;
using GAC.Application.Services.Identity.Dtos.User;
using GAC.Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GAC.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;

        public AuthController(
            IAuthService authService,
            UserManager<ApplicationUser> userManager,
            IConfiguration configuration)
        {
            _authService = authService;
            _userManager = userManager;
            _configuration = configuration;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _authService.RegisterAsync(model); 

            return Ok(new { Message = "User registered successfully." });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var authResult = await _authService.LoginAsync(model, isApiLogin: true);

            if (authResult == null)
                return Unauthorized(new { Message = "InvalidCredentials" });

            return Ok(authResult);
        }

        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto model)
        {
            var res = await _authService.ChangePasswordAsync(model);
            if (!res.IsSucceeded) return StatusCode(res.StatusCode, new { res.Message });
            return Ok(new { message = res.Message });
        }
    }
}
