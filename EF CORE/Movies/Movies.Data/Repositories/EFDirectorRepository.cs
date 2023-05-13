using Microsoft.EntityFrameworkCore;
using Movies.Data.Data;
using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Data.Repositories
{
    public class EFDirectorRepository : IDirectorRepository
    {
        private readonly MoviesDbContext dbContext;

        public EFDirectorRepository(MoviesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CreateAsync(Director entity)
        {
            await dbContext.Directors.AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Director>> GetAllAsync()
        {
            return await dbContext.Directors.AsNoTracking().ToListAsync();
        }

        public async Task<Director?> GetByIdAsync(int id)
        {
            return await dbContext.Directors.AsNoTracking().FirstOrDefaultAsync(d=>d.Id==id);
        }

        public async Task UpdateAsync(Director entity)
        {
            dbContext.Directors.Update(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
