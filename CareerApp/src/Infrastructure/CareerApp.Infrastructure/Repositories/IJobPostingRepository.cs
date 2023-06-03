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
        public IEnumerable<JobPosting> GetJobPostingByJob(int jobId);
        public IEnumerable<JobPosting> GetJobPostingByCity(int cityId);
    }
}
