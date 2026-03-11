using GAC.Common.Constants;

namespace GAC.Application.Services.Locations.Dtos;
    public class GetLocationDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

