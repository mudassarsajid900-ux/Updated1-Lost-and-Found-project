using GAC.Application.Interfaces.Replacement;
using GAC.Application.Services.Replacement.Dtos;
using GAC.Common.Constants;
using GAC.Common.Responce;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GAC.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ReplacementController : ControllerBase
    {
        private readonly IReplacementService _replacementService;

        public ReplacementController(IReplacementService replacementService)
        {
            _replacementService = replacementService;
        }

        [HttpPost("create")]
        public async Task<ActionResult<Response<GetReplacementDto>>> CreateReplacement(CreateReplacementDto dto)
        {
            var result = await _replacementService.CreateReplacementAsync(dto);
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Response<GetReplacementDto>>> GetById(long id)
        {
            var result = await _replacementService.GetByIdAsync(id);
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("my-replacements")]
        public async Task<ActionResult<Response<List<GetReplacementDto>>>> GetMyReplacements()
        {
            var result = await _replacementService.GetMyReplacementsAsync();
            return StatusCode(result.StatusCode, result);
        }

        [HttpGet("eligible-items")]
        public async Task<ActionResult<Response<List<ReplacementEligibleItemDto>>>> GetEligibleItems()
        {
            var result = await _replacementService.GetEligibleItemsAsync();
            return StatusCode(result.StatusCode, result);
        }

        // Admin Endpoints
        [Authorize(Roles = "Administrator,Admin")]
        [HttpGet("admin/all-pending")]
        public async Task<ActionResult<Response<List<GetReplacementDto>>>> GetAllPending()
        {
            var result = await _replacementService.GetAllPendingRequestsAsync();
            return StatusCode(result.StatusCode, result);
        }

        [Authorize(Roles = "Administrator,Admin")]
        [HttpPost("admin/process")]
        public async Task<ActionResult<Response<GetReplacementDto>>> Process(AdminProcessReplacementDto dto)
        {
            var result = await _replacementService.ProcessRequestAsync(dto);
            return StatusCode(result.StatusCode, result);
        }

        [Authorize(Roles = "Administrator,Admin")]
        [HttpGet("admin/suggestions/{requestId}")]
        public async Task<ActionResult<Response<List<long>>>> GetSuggestions(long requestId)
        {
            var result = await _replacementService.GetSmartMatchSuggestionsAsync(requestId);
            return StatusCode(result.StatusCode, result);
        }

        [Authorize(Roles = "Administrator,Admin")]
        [HttpPut("admin/settings/eligibility-threshold/{days}")]
        [HttpPost("admin/settings/eligibility-threshold/{days}")]
        public async Task<ActionResult<Response<bool>>> UpdateEligibilityThreshold(int days)
        {
            var result = await _replacementService.UpdateReplacementEligibilityThresholdAsync(days);
            return StatusCode(result.StatusCode, result);
        }

        [Authorize(Roles = "Administrator,Admin")]
        [HttpPut("admin/settings/found-to-replacement-threshold/{days}")]
        [HttpPost("admin/settings/found-to-replacement-threshold/{days}")]
        public async Task<ActionResult<Response<bool>>> UpdateFoundToReplacementThreshold(int days)
        {
            var result = await _replacementService.UpdateFoundToReplacementThresholdAsync(days);
            return StatusCode(result.StatusCode, result);
        }

        [Authorize(Roles = "Administrator,Admin")]
        [HttpPut("admin/settings/replacement-to-auction-threshold/{days}")]
        [HttpPost("admin/settings/replacement-to-auction-threshold/{days}")]
        public async Task<ActionResult<Response<bool>>> UpdateReplacementToAuctionThreshold(int days)
        {
            var result = await _replacementService.UpdateReplacementToAuctionThresholdAsync(days);
            return StatusCode(result.StatusCode, result);
        }

        [Authorize(Roles = "Administrator,Admin")]
        [HttpGet("admin/settings/thresholds")]
        public async Task<ActionResult<Response<Dictionary<string, int>>>> GetAllThresholds()
        {
            var result = await _replacementService.GetAllThresholdsAsync();
            return StatusCode(result.StatusCode, result);
        }

        [Authorize(Roles = "Administrator,Admin")]
        [HttpGet("admin/pool")]
        public async Task<ActionResult<Response<List<ReplacementPoolItemDto>>>> GetPool()
        {
            var result = await _replacementService.GetAvailablePoolItemsAsync();
            return StatusCode(result.StatusCode, result);
        }
    }
}
