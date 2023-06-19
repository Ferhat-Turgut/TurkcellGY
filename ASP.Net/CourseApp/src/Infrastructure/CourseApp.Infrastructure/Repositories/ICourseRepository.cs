using CourseApp.Entities;
using CourseApp.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Infrastructure.Repositories
{
    public interface ICourseRepository:IRepository<Course>
    {
        public IEnumerable<Course> GetCoursesByCategory(int categoryId);
        public Task<IEnumerable<Course>> GetCoursesByNameAsync(string name);
        public Task<IEnumerable<Course>> GetCoursesByCategoryAsync(int categoryId);
    }
}
