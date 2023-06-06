using CareerApp.Entities;
using CareerApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Infrastructure.Repositories
{
    public class EFRoleRepository : IRoleRepository
    {
        private readonly CareerAppDbContext careerAppDbContext;

        public EFRoleRepository(CareerAppDbContext careerAppDbContext)
        {
            this.careerAppDbContext = careerAppDbContext;
        }
        public void Create(Role entity)
        {
            careerAppDbContext.Roles.Add(entity);
            careerAppDbContext.SaveChanges();
        }

        public async Task CreateAsync(Role entity)
        {
            await careerAppDbContext.Roles.AddAsync(entity);
            await careerAppDbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deletingRole = careerAppDbContext.Roles.Find(id);
            careerAppDbContext.Roles.Remove(deletingRole);
            careerAppDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deletingRole = await careerAppDbContext.Roles.FindAsync(id);
            careerAppDbContext.Roles.Remove(deletingRole);
            await careerAppDbContext.SaveChangesAsync();
        }

        public Role? Get(int id)
        {
            return careerAppDbContext.Roles.Find(id);
        }

        public async Task<Role?> GetAsync(int id)
        {
            return await careerAppDbContext.Roles.FindAsync(id);
        }

        public  IList<Role?> GetAll()
        {
            return  careerAppDbContext.Roles.AsNoTracking().ToList();
        }

        public async Task<IList<Role?>> GetAllAsync()
        {
            return await careerAppDbContext.Roles.AsNoTracking().ToListAsync();
        }

      
        public void Update(Role entity)
        {
            careerAppDbContext.Roles.Update(entity);
            careerAppDbContext.SaveChanges();
        }

        public async Task UpdateAsync(Role entity)
        {
            careerAppDbContext.Roles.Update(entity);
            await careerAppDbContext.SaveChangesAsync();
        }
    }
}
