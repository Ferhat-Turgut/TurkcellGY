using CourseApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Infrastructure.Repositories
{
    public class FakeCourseRepository : ICourseRepository
    {
        private List<Course> _courses;
        public FakeCourseRepository() 
        {
            _courses = new()
            {
                new()
                {
                    Id= 1,Name="Course 1",Description="sport",Price=500,Rating=3,TotalHours=100
                },
                new()
                {
                    Id= 2,Name="Course 2",Description="music",Price=1000,Rating=2,TotalHours=150
                },
                new()
                {
                    Id= 3,Name="Course 3",Description="software",Price=1500,Rating=5,TotalHours=500
                }
            };
        }

        public Course? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Course?> GetAll()
        {
            return _courses;
        }

        public Task<IList<Course?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IList<Course> GetAllWithPredicate(Expression<Predicate<Course>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Course?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCoursesByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCoursesByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
