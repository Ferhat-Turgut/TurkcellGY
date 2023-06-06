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
    public class EFRecourseRepository : IRecourseRepository
    {
        private readonly CareerAppDbContext careerAppDbContext;

        public EFRecourseRepository(CareerAppDbContext careerAppDbContext)
        {
            this.careerAppDbContext = careerAppDbContext;
        }
        public void Create(Recourse entity)
        {
            careerAppDbContext.Recourses.Add(entity);
            careerAppDbContext.SaveChanges();
        }

        public async Task CreateAsync(Recourse entity)
        {
            await careerAppDbContext.Recourses.AddAsync(entity);
            await careerAppDbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deletingRecourse= careerAppDbContext.Recourses.Find(id);
            careerAppDbContext.Recourses.Remove(deletingRecourse);
            careerAppDbContext.SaveChanges();

        }

        public async Task DeleteAsync(int id)
        {
            var deletingRecourse = await careerAppDbContext.Recourses.FindAsync(id);
            careerAppDbContext.Recourses.Remove(deletingRecourse);
            await careerAppDbContext.SaveChangesAsync();
        }

        public Recourse? Get(int id)
        {
            return careerAppDbContext.Recourses.SingleOrDefault(r=>r.Id==id);
        }

        public async Task<Recourse?> GetAsync(int id)
        {
            return await careerAppDbContext.Recourses.SingleOrDefaultAsync(r=>r.Id==id);
        }
        public IList<Recourse?> GetAll()
        {
            return careerAppDbContext.Recourses.AsNoTracking().ToList();
        }

        public async Task<IList<Recourse?>> GetAllAsync()
        {
            return await careerAppDbContext.Recourses.AsNoTracking().ToListAsync();
        }
        public void Update(Recourse entity)
        {
            careerAppDbContext.Recourses.Update(entity);
            careerAppDbContext.SaveChanges();
        }

        public async Task UpdateAsync(Recourse entity)
        {
            careerAppDbContext.Recourses.Update(entity);
            await careerAppDbContext.SaveChangesAsync();
        }


        public IEnumerable<Recourse> GetRecoursesByCompany(int companyId)
        {
            return careerAppDbContext.Recourses.AsNoTracking().Where(r => r.CompanyId == companyId).ToList();
        }

        public async Task<IEnumerable<Recourse>> GetRecoursesByCompanyAsync(int companyId)
        {
            return await careerAppDbContext.Recourses.AsNoTracking().Where(r => r.CompanyId == companyId).ToListAsync();
        }

        
        public IEnumerable<Recourse> GetRecoursesByJobSeeker(int jobSeekerId)
        {
            return careerAppDbContext.Recourses.AsNoTracking().Where(r => r.JobSeekerId == jobSeekerId).ToList();
        }

        public async Task<IEnumerable<Recourse>> GetRecoursesByJobSeekerAsync(int jobSeekerId)
        {
            return await careerAppDbContext.Recourses.AsNoTracking().Where(r => r.JobSeekerId == jobSeekerId).ToListAsync();
        }

        public IEnumerable<Recourse> GetRecoursesByJob(int jobPostingId)
        {
            return careerAppDbContext.Recourses.AsNoTracking().Where(r => r.JobPostingId == jobPostingId).ToList();
        }

        public async Task<IEnumerable<Recourse>> GetRecoursesByJobAsync(int jobPostingId)
        {
            return await careerAppDbContext.Recourses.AsNoTracking().Where(r => r.JobPostingId == jobPostingId).ToListAsync();
        }
    }
}
