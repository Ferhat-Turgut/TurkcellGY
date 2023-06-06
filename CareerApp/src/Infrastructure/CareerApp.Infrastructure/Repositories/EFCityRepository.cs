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
    public class EFCityRepository : ICityRepository
    {
        private readonly CareerAppDbContext careerAppDbContext;

        public EFCityRepository(CareerAppDbContext careerAppDbContext)
        {
            this.careerAppDbContext = careerAppDbContext;
        }
        public void Create(City entity)
        {
            careerAppDbContext.Cities.Add(entity);
            careerAppDbContext.SaveChanges();
        }

        public async Task CreateAsync(City entity)
        {
            await careerAppDbContext.Cities.AddAsync(entity);
            await careerAppDbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deletingCity = careerAppDbContext.Cities.Find(id);
            careerAppDbContext.Cities.Remove(deletingCity);
            careerAppDbContext.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var deletingCity =await careerAppDbContext.Cities.FindAsync(id);
            careerAppDbContext.Cities.Remove(deletingCity);
            await careerAppDbContext.SaveChangesAsync();
        }

        public City? Get(int id)
        {
            return careerAppDbContext.Cities.AsNoTracking().SingleOrDefault(c=>c.Id==id);
        }

        public async Task<City?> GetAsync(int id)
        {
            return await careerAppDbContext.Cities.AsNoTracking().SingleOrDefaultAsync(c=>c.Id==id);
        }

        public IList<City?> GetAll()
        {
            return careerAppDbContext.Cities.AsNoTracking().ToList();
        }

        public async Task<IList<City?>> GetAllAsync()
        {
            return await careerAppDbContext.Cities.AsNoTracking().ToListAsync();
        }

       

        public void Update(City entity)
        {
            careerAppDbContext.Cities.Update(entity);
            careerAppDbContext.SaveChanges();
        }

        public async Task UpdateAsync(City entity)
        {
            careerAppDbContext.Cities.Update(entity);
            await careerAppDbContext.SaveChangesAsync();
        }
    }
}
