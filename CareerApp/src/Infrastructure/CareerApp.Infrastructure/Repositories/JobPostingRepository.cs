using CareerApp.Entities;
using CareerApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Infrastructure.Repositories
{
    public class JobPostingRepository : IJobPostingRepository
    {
        private readonly CareerAppDbContext dbContext;

        public JobPostingRepository(CareerAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public JobPosting? Get(int id)
        {
            throw new NotImplementedException();
        }
        public Task<JobPosting?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IList<JobPosting?> GetAll()
        {
            return dbContext.JobPostings.ToList();
        }

        public async Task<IList<JobPosting?>> GetAllAsync()
        {
            return await dbContext.JobPostings.ToListAsync();
        }


        public IEnumerable<JobPosting> GetJobPostingByCity(int cityId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JobPosting> GetJobPostingByJob(int jobId)
        {
            throw new NotImplementedException();
        }
    }
}
