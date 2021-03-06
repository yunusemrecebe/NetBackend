using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter);
        IList<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        Task<IList<T>> GetListAsync(Expression<Func<T, bool>> filter = null);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
