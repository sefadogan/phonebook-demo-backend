using Sefd.Phonebook.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Sefd.Phonebook.Core.DataAccess
{
    public interface IEntityRepository<TEntity>
         where TEntity : class, IEntity, new()
    {
        Task<ICollection<TEntity>> ListAsync(Expression<Func<TEntity, bool>> where = null, params Expression<Func<TEntity, object>>[] includes);
        Task<TEntity> GetByIdAsync(int id);
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task UpdatePartialAsync(int id, object entity);
    }
}
