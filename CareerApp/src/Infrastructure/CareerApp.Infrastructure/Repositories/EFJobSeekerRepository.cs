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
    public class EFJobSeekerRepository : IJobSeekerRepository
    {
        private readonly CareerAppDbContext careerAppDbContext;

        public EFJobSeekerRepository(CareerAppDbContext careerAppDbContext)
        {
            this.careerAppDbContext = careerAppDbContext;
        }
        public void Create(JobSeeker entity)
        {
            careerAppDbContext.JobSeekers.Add(entity);
            careerAppDbContext.SaveChanges();
        }

        public async Task CreateAsync(JobSeeker entity)
        {
            await careerAppDbContext.JobSeekers.AddAsync(entity);
            await careerAppDbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deletingJobSeeker = careerAppDbContext.JobSeekers.Find(id);
            careerAppDbContext.JobSeekers.Remove(deletingJobSeeker);
            careerAppDbContext.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var deletingJobSeeker =await careerAppDbContext.JobSeekers.FindAsync(id);
            careerAppDbContext.JobSeekers.Remove(deletingJobSeeker);
            await careerAppDbContext.SaveChangesAsync();
        }

        public JobSeeker? Get(int id)
        {
            return careerAppDbContext.JobSeekers.AsNoTracking().SingleOrDefault(j=>j.Id==id);
        }
        public async Task<JobSeeker?> GetAsync(int id)
        {
            return await careerAppDbContext.JobSeekers.AsNoTracking().SingleOrDefaultAsync(j => j.Id == id);
        }

        public  IList<JobSeeker?> GetAll()
        {
            return careerAppDbContext.JobSeekers.AsNoTracking().ToList();
        }

        public async Task<IList<JobSeeker?>> GetAllAsync()
        {
            return await careerAppDbContext.JobSeekers.AsNoTracking().ToListAsync();
        }

        public  void Update(JobSeeker entity)
        {
            careerAppDbContext.JobSeekers.Update(entity);
            careerAppDbContext.SaveChanges();
        }

        public async Task UpdateAsync(JobSeeker entity)
        {
            careerAppDbContext.JobSeekers.Update(entity);
            await careerAppDbContext.SaveChangesAsync();
        }

        public IEnumerable<JobSeeker> GetJobSeekersByJob(int jobId)
        {
            return careerAppDbContext.JobSeekers.AsNoTracking().Where(j => j.JobId == jobId).ToList();
        }

        public async Task<IEnumerable<JobSeeker>> GetJobSeekersByJobAsync(int jobId)
        {
            return await careerAppDbContext.JobSeekers.AsNoTracking().Where(j => j.JobId == jobId).ToListAsync();
        }
    }
}
