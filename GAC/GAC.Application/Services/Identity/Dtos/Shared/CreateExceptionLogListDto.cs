namespace GAC.Application.Services.Identity.Dtos.Shared
{
    public class CreateExceptionLogListDto
    {
        public List<CreateExceptionLogDto> Logs { get; set; } = new List<CreateExceptionLogDto>();
        public string CreatedAt { get; set; } 
    }
}
