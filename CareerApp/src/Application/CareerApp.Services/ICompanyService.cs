using CareerApp.DataTransferObject.Requests;
using CareerApp.DataTransferObject.Responses;

namespace CareerApp.Services
{
    public interface ICompanyService
    {
        CompanyDisplayResponse GetCompany(int id);
        Task<CompanyDisplayResponse> GetCompanyAsync(int id);

        CompanyDisplayResponse GetCompanyByUsername(string username);
        Task<CompanyDisplayResponse> GetCompanyByUsernameAsync(string username);
        IEnumerable<CompanyDisplayResponse> GetCompanyDisplayResponses();
        Task<IEnumerable<CompanyDisplayResponse>> GetCompanyDisplayResponsesAsync();

        void CreateCompany(CreateNewCompanyRequest createNewCompanyRequest);
        Task CreateCompanyAsync(CreateNewCompanyRequest createNewCompanyRequest);

        UpdateCompanyRequest GetCompanyForUpdate(int id);
        Task<UpdateCompanyRequest> GetCompanyForUpdateAsync(int id);

        void UpdateCompany(UpdateCompanyRequest updateCompanyRequest);
        Task UpdateCompanyAsync(UpdateCompanyRequest updateCompanyRequest);
        bool IsCompanyExist(string companyUsername, string password);
        Task< bool> IsCompanyExistAsync(string companyUsername, string password);

        void DeleteCompany(int id);
        Task DeleteCompanyAsync(int id);
    }
}
