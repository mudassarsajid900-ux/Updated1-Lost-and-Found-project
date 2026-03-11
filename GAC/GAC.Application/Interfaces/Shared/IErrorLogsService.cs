using GAC.Application.Pagination;
using GAC.Application.Services.Logs.Dtos;
using GAC.Common.Pagination;
using GAC.Common.Responce;

namespace GAC.Application.Interfaces.Shared
{
    public interface IErrorLogsService
    {
        Task<Response<PagedResult<ExceptionLogListingDto>>> GetAllExceptionLogs(DataTableRequest request);
        Task<Response<PagedResult<AuditLogListingDto>>> GetAllAduitLogs(DataTableRequest request, int? userId);
    }
}
