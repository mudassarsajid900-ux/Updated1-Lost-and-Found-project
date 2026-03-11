using GAC.Application.Extensions;
using GAC.Application.Interfaces.Locations;
using GAC.Application.Services.Locations.Dtos;
using GAC.Common.Constants;
using Microsoft.AspNetCore.Mvc;

namespace GAC.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LocationController : ControllerBase
{
    private readonly ILocationService _locationService;

    public LocationController(ILocationService locationService)
    {
        _locationService = locationService;
    }

    [HttpPost(ApiConstatnts.Create)]
    public async Task<IActionResult> Create(CreateLocationDto dto)
    {
        var response = await _locationService.CreateAsync(dto);
        return response.ToHttpResult();
    }

    [HttpPut(ApiConstatnts.Update)]
    public async Task<IActionResult> Update(UpdateLocationDto dto)
    {
        var response = await _locationService.UpdateAsync(dto);
        return response.ToHttpResult();
    }

    [HttpGet(ApiConstatnts.GetItemBy)]
    public async Task<IActionResult> Get(long id)
    {
        var response = await _locationService.GetByIdAsync(id);
        return response.ToHttpResult();
    }

    [HttpGet(ApiConstatnts.GetAll)]
    public async Task<IActionResult> GetAll()
    {
        var response = await _locationService.GetAllAsync();
        return response.ToHttpResult();
    }

    [HttpDelete(ApiConstatnts.DeleteItemBy)]
    public async Task<IActionResult> Delete(long id)
    {
        var response = await _locationService.DeleteAsync(id);
        return response.ToHttpResult();
    }
}

