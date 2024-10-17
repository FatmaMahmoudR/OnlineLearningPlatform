using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Models;
using System.Linq.Expressions;

namespace OnlineLearningPlatform.App.interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression = null,
            string[] inculdes = null);
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);  // Soft delete
        Task<T> GetWithNoFiltersAsync(int id);
        Task<List<T>> GetAllToListAsync(Expression<Func<T, bool>> predicate);
    }
}

