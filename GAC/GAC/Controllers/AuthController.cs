using GAC.Application.Interfaces.Identity;
using GAC.Application.Services.Identity.Dtos.Auth;
using GAC.Application.Services.Identity.Dtos.User;
using GAC.Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace GAC.API.Controllers
{
    /// <summary>
    /// Core Authentication Controller.
    /// Handles user registration, login (JWT generation), and password management.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Initializes the AuthController with required identity services and configuration.
        /// </summary>
        public AuthController(
            IAuthService authService,
            UserManager<ApplicationUser> userManager,
            IConfiguration configuration)
        {
            _authService = authService;
            _userManager = userManager;
            _configuration = configuration;
        }

        /// <summary>
        /// Processes new user registrations.
        /// Validates input, hashes passwords, and creates default user roles.
        /// </summary>
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto model)
        {
            // 1. Initial layer validation (DataAnnotations on DTO)
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // 2. Pass control to application service for domain logic
            await _authService.RegisterAsync(model); 

            // 3. Inform client of success
            return Ok(new { Message = "User registered successfully." });
        }

        /// <summary>
        /// Authenticates users and dispenses JWT tokens upon success.
        /// </summary>
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto model)
        {
            // 1. Input validation
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // 2. Perform authentication and generate token payload
            var authResult = await _authService.LoginAsync(model, isApiLogin: true);

            // 3. Guard against unauthorized access
            if (authResult == null)
                return Unauthorized(new { Message = "InvalidCredentials" });

            // 4. Return standard authorized response payload containing active Tokens
            return Ok(authResult);
        }

        /// <summary>
        /// Allows authenticated users to update their passwords.
        /// </summary>
        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto model)
        {
            // Delegate logic to underlying service implementation
            var res = await _authService.ChangePasswordAsync(model);
            
            // Standardize output response format based on Result context
            if (!res.IsSucceeded) return StatusCode(res.StatusCode, new { res.Message });
            
            return Ok(new { message = res.Message });
        }
    }
}
