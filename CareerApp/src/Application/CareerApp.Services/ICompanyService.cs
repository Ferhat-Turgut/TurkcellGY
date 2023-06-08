using CareerApp.DataTransferObject.Requests;
using CareerApp.DataTransferObject.Responses;

namespace CareerApp.Services
{
    public interface ICompanyService
    {
        CompanyDisplayResponse GetCompany(int id);
        Task<CompanyDisplayResponse> GetCompanyAsync(int id);

        IEnumerable<CompanyDisplayResponse> GetCompanyDisplayResponses();
        Task<IEnumerable<CompanyDisplayResponse>> GetCompanyDisplayResponsesAsync();

        void CreateCompany(CreateNewCompanyRequest createNewCompanyRequest);
        Task CreateCompanyAsync(CreateNewCompanyRequest createNewCompanyRequest);

        UpdateCompanyRequest GetCompanyForUpdate(int id);
        Task<UpdateCompanyRequest> GetCompanyForUpdateAsync(int id);

        void UpdateCompany(UpdateCompanyRequest updateCompanyRequest);
        Task UpdateCompanyAsync(UpdateCompanyRequest updateCompanyRequest);

        void DeleteCompany(int id);
        Task DeleteCompanyAsync(int id);
    }
}
