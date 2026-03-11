using AutoMapper;
using GAC.Application.Interfaces.Locations;
using GAC.Application.Interfaces.Shared;
using GAC.Application.Services.Locations.Dtos;
using GAC.Common.Responce;
using GAC.Core.Entities.Locations;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace GAC.Application.Services.Locations;

public class LocationService : ILocationService
{
    private readonly IGenericRepository<Location> _locationRepository;
    private readonly IMapper _mapper;

    public LocationService(
        IGenericRepository<Location> locationRepository,
        IMapper mapper)
    {
        _locationRepository = locationRepository;
        _mapper = mapper;
    }

    public async Task<Response<GetLocationDto>> CreateAsync(CreateLocationDto dto)
    {
        var entity = _mapper.Map<Location>(dto);

        await _locationRepository.AddAsync(entity);

        var result = await GetByIdAsync(entity.Id);

        return Response<GetLocationDto>.SetSuccessResponse(
            result.Data,
            "Location created successfully",
            StatusCodes.Status201Created);
    }

    public async Task<Response<GetLocationDto>> UpdateAsync(UpdateLocationDto dto)
    {
        var existing = await _locationRepository
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == dto.Id);

        if (existing == null)
            return Response<GetLocationDto>.NotFoundResponse();

        _mapper.Map(dto, existing);

        await _locationRepository.UpdateAsync(existing);

        var updated = await GetByIdAsync(existing.Id);

        return Response<GetLocationDto>.SetSuccessResponse(
            updated.Data,
            "Location updated successfully");
    }

    public async Task<Response<GetLocationDto>> GetByIdAsync(long id)
    {
        var entity = await _locationRepository
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);

        if (entity == null)
            return Response<GetLocationDto>.NotFoundResponse();

        var dto = _mapper.Map<GetLocationDto>(entity);

        return Response<GetLocationDto>.SetSuccessResponse(dto);
    }

    public async Task<Response<List<GetLocationDto>>> GetAllAsync()
    {
        var locations = await _locationRepository
            .AsNoTracking()
            .ToListAsync();

        var dtoList = _mapper.Map<List<GetLocationDto>>(locations);

        return Response<List<GetLocationDto>>.SetSuccessResponse(dtoList);
    }

    public async Task<Response<string>> DeleteAsync(long id)
    {
        var entity = await _locationRepository.GetByIdAsync((int)id);

        if (entity == null)
            return Response<string>.NotFoundResponse();

        await _locationRepository.DeleteAsync(id);

        return Response<string>.SetSuccessMessageResponse("Location deleted successfully");
    }
}

