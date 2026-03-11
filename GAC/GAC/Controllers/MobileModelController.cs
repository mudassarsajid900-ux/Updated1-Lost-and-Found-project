using GAC.Application.Interfaces.Item;
using GAC.Application.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace GAC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileModelController : ControllerBase
    {
        private readonly IMobileModelService _mobileModelService;

        public MobileModelController(IMobileModelService mobileModelService)
        {
            _mobileModelService = mobileModelService;
        }

        [HttpGet("companies")]
        public async Task<IActionResult> GetCompanies()
        {
            var response = await _mobileModelService.GetCompaniesAsync();
            return response.ToHttpResult();
        }

        [HttpGet("companies/{companyId}/models")]
        public async Task<IActionResult> GetModelsByCompany(long companyId)
        {
            var response = await _mobileModelService.GetModelsByCompanyAsync(companyId);
            return response.ToHttpResult();
        }
    }
}
