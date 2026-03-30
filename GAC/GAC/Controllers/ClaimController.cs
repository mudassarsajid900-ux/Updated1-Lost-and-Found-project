using GAC.Application.Interfaces.ClaimRequests;
using GAC.Application.Services.ClaimRequests.Dtos;
using GAC.Common.Responce;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GAC.Common.Constants;

namespace GAC.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : ControllerBase
    {
        private readonly IClaimService _claimService;

        public ClaimController(IClaimService claimService)
        {
            _claimService = claimService;
        }

        [HttpPost("submit")]
        public async Task<ActionResult<Response<GetClaimDto>>> SubmitClaim(CreateClaimDto dto)
        {
            var result = await _claimService.SubmitClaimAsync(dto);
            return StatusCode(result.StatusCode, result);
        }

        [Authorize(Roles = ApplicationConstants.AdministratorRole)]
        [HttpPut("update-status")]
        public async Task<ActionResult<Response<GetClaimDto>>> UpdateStatus(UpdateClaimStatusDto dto)
        {
            var result = await _claimService.UpdateClaimStatusAsync(dto);
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Response<GetClaimDto>>> GetById(long id)
        {
            var result = await _claimService.GetByIdAsync(id);
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("my-claims")]
        public async Task<ActionResult<Response<List<GetClaimDto>>>> GetMyClaims()
        {
            var result = await _claimService.GetMyClaimsAsync();
            return StatusCode(result.StatusCode, result);
        }

        [Authorize(Roles = ApplicationConstants.AdministratorRole)]
        [HttpGet("all")]
        public async Task<ActionResult<Response<List<GetClaimDto>>>> GetAllClaims()
        {
            var result = await _claimService.GetAllClaimsAsync();
            return StatusCode(result.StatusCode, result);
        }
    }
}
