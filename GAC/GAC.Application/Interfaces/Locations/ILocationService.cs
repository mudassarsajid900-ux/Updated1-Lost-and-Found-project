using GAC.Application.Services.Locations.Dtos;
using GAC.Common.Responce;

namespace GAC.Application.Interfaces.Locations;
public interface ILocationService
{
    Task<Response<GetLocationDto>> CreateAsync(CreateLocationDto dto);
    Task<Response<GetLocationDto>> UpdateAsync(UpdateLocationDto dto);
    Task<Response<GetLocationDto>> GetByIdAsync(long id);
    Task<Response<List<GetLocationDto>>> GetAllAsync();
    Task<Response<string>> DeleteAsync(long id);
}
