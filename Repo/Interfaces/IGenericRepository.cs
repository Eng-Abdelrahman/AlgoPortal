using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Interfaces
{
    public interface IGenericRepository<TEntity>
    {
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entites);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entites);
        Task<TEntity> GetAsync(Guid id);
        Task<List<TEntity>> GetAllAsync();
        Task<int> SaveChangesAsync();
    }
}
