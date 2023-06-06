using CareerApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Infrastructure.Repositories
{
    public interface IJobSeekerRepository:IRepository<JobSeeker>
    {
        public IEnumerable<JobSeeker> GetJobSeekersByJob(int jobId);
        public Task<IEnumerable<JobSeeker>> GetJobSeekersByJobAsync(int jobId);
    }
}
