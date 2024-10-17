using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using OnlineLearningPlatform.Models;
using OnlineLearningPlatform.App.interfaces;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private context _db;
    private DbSet<T> _dbSet;
    public GenericRepository(context db)
    {
        _db = db;
        _dbSet = _db.Set<T>();
    }

    public async Task<T> AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _db.SaveChangesAsync();
        return entity;
    }

   
    public async Task DeleteAsync(int id)
    {
        var item = await GetByIdAsync(id);
        _dbSet.Remove(item);
        await _db.SaveChangesAsync();
    }

    public async Task SoftDeleteAsync(int id)  // Soft delete
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _db.Entry(entity).Property("Deleted").CurrentValue = true;  // Mark as deleted
            _dbSet.Update(entity);
            await _db.SaveChangesAsync();
        }
    }

    public async Task<T> GetWithNoFiltersAsync(int id)
    {
        return await _dbSet.IgnoreQueryFilters().FirstOrDefaultAsync(e => EF.Property<int>(e, "Id") == id);
    }



    public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression = null,
string[] includes = null)
    {
        IQueryable<T> query = _dbSet;
        if (includes != null)
        {
            foreach (var include in includes)
            {
                query = query.Include(include).AsSplitQuery();
            }
        }
        if (expression != null)
        {
            return query.Where(expression);
        }

        return await query.ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<T> UpdateAsync(T entity)
    {
        _dbSet.Update(entity);
        await _db.SaveChangesAsync();
        return entity;
    }

    public async Task<List<T>> GetAllToListAsync(Expression<Func<T, bool>> predicate)
    {
        return await _dbSet.Where(predicate).ToListAsync();
    }



}