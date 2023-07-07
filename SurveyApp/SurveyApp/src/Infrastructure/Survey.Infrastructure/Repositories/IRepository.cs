using SurveyApp.Entities;
using System.Linq.Expressions;

namespace SurveyApp.Infrastructure.Repositories
{
    public interface IRepository<T> where T : class, IEntity , new()
    {
        

        void Create(T entity);
        Task CreateAsync(T entity);
    }
}
