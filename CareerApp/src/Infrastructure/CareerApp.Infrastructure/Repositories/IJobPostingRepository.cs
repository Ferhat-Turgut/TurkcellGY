using CareerApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Infrastructure.Repositories
{
    public interface IJobPostingRepository:IRepository<JobPosting>
    {
        public IEnumerable<JobPosting> GetJobPostingsByJob(int jobId);
        public Task<IEnumerable<JobPosting>> GetJobPostingsByJobAsync(int jobId);
        public IEnumerable<JobPosting> GetJobPostingsByCompany(int companyId);
        public Task<IEnumerable<JobPosting>> GetJobPostingsByCompanyAsync(int companyId);
        public IEnumerable<JobPosting> GetAllActiveJobPostings();
        public Task<IEnumerable<JobPosting>> GetAllActiveJobPostingsAsync();
        public void ChangeJobPostingStatus(int id);
        public Task ChangeJobPostingStatusAsync(int id);
    }
}
