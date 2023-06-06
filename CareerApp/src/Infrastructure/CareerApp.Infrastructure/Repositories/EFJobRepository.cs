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
    public class EFJobRepository : IJobRepository
    {
        private readonly CareerAppDbContext careerAppDbContext;

        public EFJobRepository(CareerAppDbContext careerAppDbContext)
        {
            this.careerAppDbContext = careerAppDbContext;
        }
        public void Create(Job entity)
        {
            careerAppDbContext.Jobs.Add(entity);
            careerAppDbContext.SaveChanges();
        }

        public async Task CreateAsync(Job entity)
        {
            await careerAppDbContext.Jobs.AddAsync(entity);
            await careerAppDbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deletingJob = careerAppDbContext.Jobs.Find(id);
            careerAppDbContext.Jobs.Remove(deletingJob);
            careerAppDbContext.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var deletingJob = await careerAppDbContext.Jobs.FindAsync(id);
            careerAppDbContext.Jobs.Remove(deletingJob);
            await careerAppDbContext.SaveChangesAsync();
        }

        public Job? Get(int id)
        {
            return careerAppDbContext.Jobs.AsNoTracking().SingleOrDefault(j => j.Id == id);
        }

        public async Task<Job?> GetAsync(int id)
        {
            return await careerAppDbContext.Jobs.AsNoTracking().SingleOrDefaultAsync(j => j.Id == id);
        }
        public IList<Job?> GetAll()
        {
            return careerAppDbContext.Jobs.AsNoTracking().ToList();
        }

        public async Task<IList<Job?>> GetAllAsync()
        {
            return await careerAppDbContext.Jobs.AsNoTracking().ToListAsync();
        }

        

        public void Update(Job entity)
        {
            careerAppDbContext.Jobs.Update(entity);
            careerAppDbContext.SaveChanges();
        }

        public async Task UpdateAsync(Job entity)
        {
            careerAppDbContext.Jobs.Update(entity);
            await careerAppDbContext.SaveChangesAsync();
        }
    }
}
