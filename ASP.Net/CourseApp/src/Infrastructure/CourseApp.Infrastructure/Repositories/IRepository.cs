using CourseApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Services.Repositories
{
    public interface IRepository<T> where T : class,IEntity, new()
    {
        T? Get(int id);
        Task<T?> GetAsync(int id);
        IList<T?> GetAll();
        Task<IList<T?>> GetAllAsync();
        IList<T> GetAllWithPredicate(Expression<Predicate<T>> predicate);
    }
}
