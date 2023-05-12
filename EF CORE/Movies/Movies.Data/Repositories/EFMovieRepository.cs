using Movies.Data.Data;
using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies.Entities;
using Movies.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Movies.Data.Repositories
{
    
    public class EFMovieRepository : IMovieRepository
    {
        private readonly MoviesDbContext moviesDbContext;
        public EFMovieRepository(MoviesDbContext moviesDbContext) 
        {
            this.moviesDbContext = moviesDbContext;
        }
        public void Create(Movie entity) 
        {
            throw new NotImplementedException();
        }
        public async Task CreateAsync(Movie entity)
        {
            await moviesDbContext.Movies.AddAsync(entity);
            await moviesDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var product =await moviesDbContext.Movies.AsNoTracking().FirstOrDefaultAsync(m=>m.Id==id);
            moviesDbContext.Movies.Remove(product);
            await moviesDbContext.SaveChangesAsync();
        }

        public async Task<IList<Movie>> GetAllAsync()
        {
            return await moviesDbContext.Movies.AsNoTracking().ToListAsync();
        }

        public async Task<Movie?> GetByIdAsync(int id)
        {
            return await moviesDbContext.Movies.AsNoTracking().FirstOrDefaultAsync(m=>m.Id==id);
        }

        public async Task<IEnumerable<Movie>> SearchMoviesByTitlle(string tittle)
        {
            return await moviesDbContext.Movies.AsNoTracking()
                                                .Where(m=>m.Name.Contains(tittle))
                                                .ToListAsync();
        }

        public async Task UpdateAsync(Movie entity)
        {
            moviesDbContext.Movies.Update(entity);
            await moviesDbContext.SaveChangesAsync();
        }
    }
}
