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
    public class EFCourseRepository : ICourseRepository
    {
        private readonly CourseDbContext courseDbContext;

        public EFCourseRepository(CourseDbContext courseDbContext)
        {
            this.courseDbContext = courseDbContext;
        }

        public async Task CreateAsync(Course entity)
        {
            await courseDbContext.courses.AddAsync(entity);
            await courseDbContext.SaveChangesAsync();
        }


        public async Task DeleteAsync(int id)
        {
            var deletingCourse =await courseDbContext.courses.FindAsync(id);
            courseDbContext.courses.Remove(deletingCourse);
            await courseDbContext.SaveChangesAsync();
        }

        public Course? Get(int id)
        {
            return courseDbContext.courses.SingleOrDefault(c=>c.Id==id);
        }

        public IList<Course?> GetAll()
        {
            return courseDbContext.courses.AsNoTracking().ToList();
        }

        public async Task<IList<Course?>> GetAllAsync()
        {
            return await courseDbContext.courses.AsNoTracking().ToListAsync();
        }

        public IList<Course> GetAllWithPredicate(Expression<Func<Course, bool>> predicate)
        {
            return courseDbContext.courses.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<Course?> GetAsync(int id)
        {
            return await courseDbContext.courses.AsNoTracking().FirstAsync(c=>c.Id==id);
        }

        public IEnumerable<Course> GetCoursesByCategory(int categoryId)
        {
            return courseDbContext.courses.AsNoTracking().Where(c=>c.CategoryId==categoryId).ToList().AsEnumerable();
        }

        public async Task<IEnumerable<Course>> GetCoursesByCategoryAsync(int categoryId)
        {
            return await courseDbContext.courses.AsNoTracking().Where(c => c.CategoryId == categoryId).ToListAsync();
        }

      

        public async Task<IEnumerable<Course>> GetCoursesByNameAsync(string name)
        {
            return await courseDbContext.courses.AsNoTracking().Where(c => c.Name.Contains(name)).ToListAsync();
        }

        public async Task<bool> IsExistAsync(int id)
        {
            return await courseDbContext.courses.AnyAsync(c=>c.Id==id);
        }

        public async Task UpdateAsync(Course entity)
        {
            courseDbContext.courses.Update(entity);
            await courseDbContext.SaveChangesAsync();
        }
    }
}
