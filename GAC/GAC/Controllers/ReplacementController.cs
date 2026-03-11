using GAC.Application.Interfaces.Replacement;
using GAC.Application.Services.Replacement.Dtos;
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
    }
}
