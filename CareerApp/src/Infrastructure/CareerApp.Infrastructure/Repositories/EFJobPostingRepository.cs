using CareerApp.Entities;
using CareerApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Infrastructure.Repositories
{
    public class EFJobPostingRepository : IJobPostingRepository
    {
        private readonly CareerAppDbContext careerAppDbContext;

        public EFJobPostingRepository(CareerAppDbContext careerAppDbContext)
        {
            this.careerAppDbContext = careerAppDbContext;
        }
        public void Create(JobPosting entity)
        {
            careerAppDbContext.JobPostings.Add(entity);
            careerAppDbContext.SaveChanges();
        }

        public async Task CreateAsync(JobPosting entity)
        {
            await careerAppDbContext.JobPostings.AddAsync(entity);
            await careerAppDbContext.SaveChangesAsync();
        }

        public  void Delete(int id)
        {
            var deletingJobPosting = careerAppDbContext.JobPostings.Find(id);
            careerAppDbContext.JobPostings.Remove(deletingJobPosting);
            careerAppDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deletingJobPosting = await careerAppDbContext.JobPostings.FindAsync(id);
            careerAppDbContext.JobPostings.Remove(deletingJobPosting);
            await careerAppDbContext.SaveChangesAsync();
        }

        public JobPosting? Get(int id)
        {
            return careerAppDbContext.JobPostings.SingleOrDefault(j => j.Id == id);
        }

        public async Task<JobPosting?> GetAsync(int id)
        {
            return await careerAppDbContext.JobPostings.SingleOrDefaultAsync(j=>j.Id==id);
        }
        public IList<JobPosting?> GetAll()
        {
            return careerAppDbContext.JobPostings.AsNoTracking().ToList();
        }

        public async Task<IList<JobPosting?>> GetAllAsync()
        {
            return await careerAppDbContext.JobPostings.AsNoTracking().ToListAsync();
        }

        public void Update(JobPosting entity)
        {
            careerAppDbContext.JobPostings.Update(entity);
            careerAppDbContext.SaveChanges();
        }

        public async Task UpdateAsync(JobPosting entity)
        {
            careerAppDbContext.JobPostings.Update(entity);
            await careerAppDbContext.SaveChangesAsync();
        }


        public IEnumerable<JobPosting> GetJobPostingsByCompany(int companyId)
        {
            return careerAppDbContext.JobPostings.AsNoTracking().Where(j => j.CompanyId == companyId).ToList();
        }

        public async Task<IEnumerable<JobPosting>> GetJobPostingsByCompanyAsync(int companyId)
        {
            return await careerAppDbContext.JobPostings.AsNoTracking().Where(j => j.CompanyId == companyId).ToListAsync();
        }

        public IEnumerable<JobPosting> GetJobPostingsByJob(int jobId)
        {
            return careerAppDbContext.JobPostings.AsNoTracking().Where(j => j.JobId == jobId).ToList();
        }

        public async Task<IEnumerable<JobPosting>> GetJobPostingsByJobAsync(int jobId)
        {
            return await careerAppDbContext.JobPostings.AsNoTracking().Where(j => j.JobId == jobId).ToListAsync();
        }

        public void ChangeJobPostingStatus(int id)
        {
            var jobPosting = careerAppDbContext.JobPostings.Find(id);
            if (jobPosting.Status==true)
            {
                jobPosting.Status = false;
            }
            else
            {
                jobPosting.Status = true;
            }
            careerAppDbContext.JobPostings.Update(jobPosting);
            careerAppDbContext.SaveChanges();
        }

        public async Task ChangeJobPostingStatusAsync(int id)
        {
            var jobPosting =await careerAppDbContext.JobPostings.FindAsync(id);
            if (jobPosting.Status == true)
            {
                jobPosting.Status = false;
            }
            else
            {
                jobPosting.Status = true;
            }
            careerAppDbContext.JobPostings.Update(jobPosting);
            await careerAppDbContext.SaveChangesAsync();
        }
    }
}
