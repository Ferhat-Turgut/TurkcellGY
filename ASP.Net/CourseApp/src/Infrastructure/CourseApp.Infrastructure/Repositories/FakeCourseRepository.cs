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
                    Id= 1,Name="Course 1",Description="Sport",Price=500,Rating=3,TotalHours=100,CategoryId=1
                },
                new()
                {
                    Id= 2,Name="Course 2",Description="Music",Price=1000,Rating=2,TotalHours=150,CategoryId=2
                },
                new()
                {
                    Id= 3,Name="Course 3",Description="Programming",Price=1500,Rating=5,TotalHours=500,CategoryId=3
                },
                new()
                {
                    Id= 4,Name="Course 4",Description="Sport2",Price=500,Rating=3,TotalHours=100,CategoryId=1
                },
                new()
                {
                    Id= 5,Name="Course 5",Description="Music2",Price=1000,Rating=2,TotalHours=150,CategoryId=2
                },
                new()
                {
                    Id= 6,Name="Course 6",Description="Programming2",Price=1500,Rating=5,TotalHours=500,CategoryId=3
                },
                new()
                {
                    Id= 7,Name="Course 7",Description="Sport3",Price=500,Rating=3,TotalHours=100,CategoryId=1
                },
                new()
                {
                    Id= 8,Name="Course 8",Description="Music3",Price=1000,Rating=2,TotalHours=150,CategoryId=2
                },
                new()
                {
                    Id= 9,Name="Course 9",Description="Programming3",Price=1500,Rating=5,TotalHours=500,CategoryId=3
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
            return _courses.Where(c => c.CategoryId == categoryId).AsEnumerable();
        }

        public IEnumerable<Course> GetCoursesByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
