using SurveyApp.Entities;
using System.Linq.Expressions;

namespace SurveyApp.Infrastructure.Repositories
{
    public interface IRepository<T> where T : class, IEntity , new()
    {
        T? Get(int id);
        Task<T?> GetAsync(int id);

        IEnumerable<T?> GetAll();
        Task<IEnumerable<T?>> GetAllAsync();

        void Create(T entity);
        Task CreateAsync(T entity);
    }
}
