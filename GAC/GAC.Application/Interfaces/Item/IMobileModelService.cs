using GAC.Application.Services.Item.Dtos;
using GAC.Common.Responce;

namespace GAC.Application.Interfaces.Item
{
    public interface IMobileModelService
    {
        Task<Response<List<MobileCompanyDto>>> GetCompaniesAsync();
        Task<Response<List<MobileModelDto>>> GetModelsByCompanyAsync(long companyId);
    }
}
