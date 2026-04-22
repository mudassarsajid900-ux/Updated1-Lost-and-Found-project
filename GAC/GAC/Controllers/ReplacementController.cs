using GAC.Application.Interfaces.Replacement;
using GAC.Application.Services.Replacement.Dtos;
using GAC.Common.Constants;
using GAC.Common.Responce;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GAC.API.Controllers
{
    /// <summary>
    /// Controller managing Item Replacement requests. 
    /// Facilitates the lifecycle of users requesting similar items from the organizational pool when original items are permanently lost.
    /// </summary>
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ReplacementController : ControllerBase
    {
        private readonly IReplacementService _replacementService;

        /// <summary>
        /// Initializes the controller with the necessary Replacement application service.
        /// </summary>
        public ReplacementController(IReplacementService replacementService)
        {
            _replacementService = replacementService;
        }

        /// <summary>
        /// Initiates a formal request for a replacement item from pool inventory.
        /// </summary>
        [HttpPost("create")]
        public async Task<ActionResult<Response<GetReplacementDto>>> CreateReplacement(CreateReplacementDto dto)
        {
            var result = await _replacementService.CreateReplacementAsync(dto);
            return StatusCode(result.StatusCode, result); // Standardizes generic Response<T> to standard REST HTTP codes
        }

        /// <summary>
        /// Retrieves the complete status and history of a specific replacement request.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<Response<GetReplacementDto>>> GetById(long id)
        {
            var result = await _replacementService.GetByIdAsync(id);
            return StatusCode(result.StatusCode, result);
        }

        /// <summary>
        /// Returns all active and historical replacement requests issued by the authenticated user.
        /// </summary>
        [HttpGet("my-replacements")]
        public async Task<ActionResult<Response<List<GetReplacementDto>>>> GetMyReplacements()
        {
            var result = await _replacementService.GetMyReplacementsAsync();
            return StatusCode(result.StatusCode, result);
        }

        /// <summary>
        /// Evaluates user's reported lost items based on system configured timeframe thresholds,
        /// returning a list of items that have surpassed the mandatory wait period and are eligible for replacement.
        /// </summary>
        [HttpGet("eligible-items")]
        public async Task<ActionResult<Response<List<ReplacementEligibleItemDto>>>> GetEligibleItems()
        {
            var result = await _replacementService.GetEligibleItemsAsync();
            return StatusCode(result.StatusCode, result);
        }

        // --- Admin Operational Endpoints ---

        /// <summary>
        /// Dashboard endpoint: Retrieves all unhandled user requests for replacements requiring administrator intervention.
        /// </summary>
        [Authorize(Roles = "Admin")]
        [HttpGet("admin/all-pending")]
        public async Task<ActionResult<Response<List<GetReplacementDto>>>> GetAllPending()
        {
            var result = await _replacementService.GetAllPendingRequestsAsync();
            return StatusCode(result.StatusCode, result);
        }

        /// <summary>
        /// Administrative action: Approves or denies a replacement and executes subsequent assignment workflows.
        /// </summary>
        [Authorize(Roles = "Admin")]
        [HttpPost("admin/process")]
        public async Task<ActionResult<Response<GetReplacementDto>>> Process(AdminProcessReplacementDto dto)
        {
            var result = await _replacementService.ProcessRequestAsync(dto);
            return StatusCode(result.StatusCode, result);
        }

        /// <summary>
        /// AI/Heuristic utility: Generates potential database matches between the requested replacement category and currently available unclaimed items.
        /// </summary>
        [Authorize(Roles = "Admin")]
        [HttpGet("admin/suggestions/{requestId}")]
        public async Task<ActionResult<Response<List<long>>>> GetSuggestions(long requestId)
        {
            var result = await _replacementService.GetSmartMatchSuggestionsAsync(requestId);
            return StatusCode(result.StatusCode, result);
        }

        /// <summary>
        /// Modifies dynamic threshold: Days a generic "Lost" item must exist before becoming eligible for replacement requests.
        /// Dual routing (PUT/POST) guarantees backwards compatibility with older client implementations.
        /// </summary>
        [Authorize(Roles = "Admin")]
        [HttpPut("admin/settings/eligibility-threshold/{days}")]
        [HttpPost("admin/settings/eligibility-threshold/{days}")]
        public async Task<ActionResult<Response<bool>>> UpdateEligibilityThreshold(int days)
        {
            var result = await _replacementService.UpdateReplacementEligibilityThresholdAsync(days);
            return StatusCode(result.StatusCode, result);
        }

        /// <summary>
        /// Modifies dynamic threshold: Days a verified "Found" item must exist without a valid claim before it is transferred into the organizational unassigned Replacement pool.
        /// </summary>
        [Authorize(Roles = "Admin")]
        [HttpPut("admin/settings/found-to-replacement-threshold/{days}")]
        [HttpPost("admin/settings/found-to-replacement-threshold/{days}")]
        public async Task<ActionResult<Response<bool>>> UpdateFoundToReplacementThreshold(int days)
        {
            var result = await _replacementService.UpdateFoundToReplacementThresholdAsync(days);
            return StatusCode(result.StatusCode, result);
        }

        /// <summary>
        /// Modifies dynamic threshold: Days a generic "Replacement" item sits in the pool before being escalated to Auction.
        /// </summary>
        [Authorize(Roles = "Admin")]
        [HttpPut("admin/settings/replacement-to-auction-threshold/{days}")]
        [HttpPost("admin/settings/replacement-to-auction-threshold/{days}")]
        public async Task<ActionResult<Response<bool>>> UpdateReplacementToAuctionThreshold(int days)
        {
            var result = await _replacementService.UpdateReplacementToAuctionThresholdAsync(days);
            return StatusCode(result.StatusCode, result);
        }

        /// <summary>
        /// Bulk retrieval endpoint for system settings synchronization on admin dashboard loading.
        /// </summary>
        [Authorize(Roles = "Admin")]
        [HttpGet("admin/settings/thresholds")]
        public async Task<ActionResult<Response<Dictionary<string, int>>>> GetAllThresholds()
        {
            var result = await _replacementService.GetAllThresholdsAsync();
            return StatusCode(result.StatusCode, result);
        }

        /// <summary>
        /// Fetches the current inventory pool available for satisfying replacement requests.
        /// </summary>
        [Authorize(Roles = "Admin")]
        [HttpGet("admin/pool")]
        public async Task<ActionResult<Response<List<ReplacementPoolItemDto>>>> GetPool()
        {
            var result = await _replacementService.GetAvailablePoolItemsAsync();
            return StatusCode(result.StatusCode, result);
        }
    }
}
