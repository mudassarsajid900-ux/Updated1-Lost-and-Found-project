using GAC.Application.Extensions;
using GAC.Application.Interfaces.Handover;
using GAC.Application.Services.Handover.Dtos;
using GAC.Common.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GAC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class HandoverController : ControllerBase
    {
        private readonly IHandoverService _handoverService;

        public HandoverController(IHandoverService handoverService)
        {
            _handoverService = handoverService;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("create")]
        public async Task<IActionResult> Create([FromForm] CreateHandoverDto dto)
        {
            var response = await _handoverService.CreateHandoverAsync(dto);
            return response.ToHttpResult();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _handoverService.GetAllHandoversAsync();
            return response.ToHttpResult();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("pending")]
        public async Task<IActionResult> GetPending()
        {
            var response = await _handoverService.GetPendingHandoversAsync();
            return response.ToHttpResult();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var response = await _handoverService.GetByIdAsync(id);
            return response.ToHttpResult();
        }
    }
}
