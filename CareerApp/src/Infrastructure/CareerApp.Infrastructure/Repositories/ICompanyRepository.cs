using CareerApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Infrastructure.Repositories
{
    public interface ICompanyRepository:IRepository<Company>
    {
        public IEnumerable<Company> GetCompaniesByName(string companyName);
        public Task<IEnumerable<Company>> GetCompaniesByNameAsync(string companyName);
        public int IsCompanyExist(string companyUsername, string password);
        public Task<int> IsCompanyExistAsync(string companyUsername, string password);
        Company GetCompanyByUsername(string username);
        Task<Company> GetCompanyByUsernameAsync(string username);
    }
}
