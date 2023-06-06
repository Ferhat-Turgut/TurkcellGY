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
    }
}
