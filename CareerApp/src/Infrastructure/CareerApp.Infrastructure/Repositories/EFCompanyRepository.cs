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
    public class EFCompanyRepository : ICompanyRepository
    {
        private readonly CareerAppDbContext careerAppDbContext;

        public EFCompanyRepository(CareerAppDbContext careerAppDbContext)
        {
            this.careerAppDbContext = careerAppDbContext;
        }
        public void Create(Company entity)
        {
            careerAppDbContext.Companies.Add(entity);
            careerAppDbContext.SaveChanges();
        }

        public async Task CreateAsync(Company entity)
        {
            await careerAppDbContext.Companies.AddAsync(entity);
            await careerAppDbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deletingCompany = careerAppDbContext.Companies.Find(id);
            careerAppDbContext.Remove(deletingCompany);
            careerAppDbContext.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var deletingCompany =await careerAppDbContext.Companies.FindAsync(id);
            careerAppDbContext.Remove(deletingCompany);
            await careerAppDbContext.SaveChangesAsync();
        }

        public Company? Get(int id)
        {
            return careerAppDbContext.Companies.SingleOrDefault(c => c.Id == id);
        }

        public async Task<Company?> GetAsync(int id)
        {
            return await careerAppDbContext.Companies.SingleOrDefaultAsync(c => c.Id == id);
        }
        public IList<Company?> GetAll()
        {
            return careerAppDbContext.Companies.AsNoTracking().ToList();
        }

        public async Task<IList<Company?>> GetAllAsync()
        {
            return await careerAppDbContext.Companies.AsNoTracking().ToListAsync();
        }

        public void Update(Company entity)
        {
            careerAppDbContext.Companies.Update(entity);
            careerAppDbContext.SaveChanges();
        }

        public async Task UpdateAsync(Company entity)
        {
            careerAppDbContext.Companies.Update(entity);
            await careerAppDbContext.SaveChangesAsync();
        }

        public IEnumerable<Company> GetCompaniesByName(string companyName)
        {
            return careerAppDbContext.Companies.Where(c => c.Name.Contains(companyName)).ToList();
        }

        public async Task<IEnumerable<Company>> GetCompaniesByNameAsync(string companyName)
        {
            return await careerAppDbContext.Companies.Where(c => c.Name.Contains(companyName)).ToListAsync();
        }

   
    }
}
