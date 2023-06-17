using CourseApp.Entities;
using CourseApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Infrastructure.Repositories
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private readonly CourseDbContext courseDbContext;

        public EFCategoryRepository(CourseDbContext courseDbContext)
        {
            this.courseDbContext = courseDbContext;
        }

        public async Task CreateAsync(Category entity)
        {
            await courseDbContext.categories.AddAsync(entity);
            courseDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deletingCategory=await courseDbContext.categories.FindAsync(id);
            courseDbContext.categories.Remove(deletingCategory);
            await courseDbContext.SaveChangesAsync();
        }

        public Category? Get(int id)
        {
            return courseDbContext.categories.FirstOrDefault(c => c.Id == id);
        }

        public IList<Category?> GetAll()
        {
            return courseDbContext.categories.AsNoTracking().ToList();
        }

        public async Task<IList<Category?>> GetAllAsync()
        {
            return await courseDbContext.categories.AsNoTracking().ToListAsync();
        }


        public IList<Category> GetAllWithPredicate(Expression<Func<Category, bool>> predicate)
        {
            return courseDbContext.categories.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<Category?> GetAsync(int id)
        {
            return await courseDbContext.categories.FirstOrDefaultAsync(c=>c.Id==id);
        }

        public Task<bool> IsExistAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Category entity)
        {
            courseDbContext.categories.Update(entity);
            await courseDbContext.SaveChangesAsync();
        }
    }
}
