using CareerApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Infrastructure.Repositories
{
    public interface IRecourseRepository:IRepository<Recourse>
    {
        public IEnumerable<Recourse> GetRecoursesByJob(int jobPostingId);
        public Task<IEnumerable<Recourse>> GetRecoursesByJobAsync(int jobPostingId);
        public IEnumerable<Recourse> GetRecoursesByCompany(int companyId);
        public Task<IEnumerable<Recourse>> GetRecoursesByCompanyAsync(int companyId);
        public IEnumerable<Recourse> GetRecoursesByJobSeeker(int jobSeekerId);
        public Task<IEnumerable<Recourse>> GetRecoursesByJobSeekerAsync(int jobSeekerId);
    }
}
