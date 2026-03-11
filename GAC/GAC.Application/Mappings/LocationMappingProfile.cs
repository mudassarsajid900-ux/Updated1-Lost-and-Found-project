using AutoMapper;
using GAC.Application.Services.Locations.Dtos;
using GAC.Core.Entities.Locations;

namespace GAC.Application.Mappings;

public class LocationMappingProfile:Profile
{
    public LocationMappingProfile()
    {
        CreateMap<CreateLocationDto, Location>();

        CreateMap<UpdateLocationDto, Location>();

        CreateMap<Location, GetLocationDto>();
    }
}

