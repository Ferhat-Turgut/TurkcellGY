using CourseApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Infrastructure.Repositories
{
    public class FakeCategoryRepository : ICategoryRepository
    {
        private List<Category> _categories;
        public FakeCategoryRepository()
        {
            _categories = new() { 
                new() {Id=1,Name="Sport"},
                new() {Id=2,Name="Music"},
                new() {Id=3,Name="Programming"}
            };
        }

        public Task CreateAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Category? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Category?> GetAll()
        {
            return _categories;
        }

        public Task<IList<Category?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IList<Category> GetAllWithPredicate(Expression<Predicate<Category>> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<Category> GetAllWithPredicate(Expression<Func<Category, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Category?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
