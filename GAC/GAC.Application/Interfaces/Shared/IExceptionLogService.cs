using GAC.Application.Services.Identity.Dtos.Shared;

namespace GAC.Application.Interfaces.Shared
{
    public interface IExceptionLogService
    {
        Task LogAsync(CreateExceptionLogDto request);
    }
}
