using Microsoft.EntityFrameworkCore;
using Sefd.Phonebook.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

namespace Sefd.Phonebook.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        #region Private Members
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbs;
        #endregion

        #region Construction Member
        public EfEntityRepositoryBase()
        {
            _context = new TContext();
            _dbs = _context.Set<TEntity>();
        }
        #endregion

        #region Methods
        public async Task<ICollection<TEntity>> ListAsync()
        {
            return await _dbs.ToListAsync();
        }

        public async Task<ICollection<TEntity>> ListAsync(Expression<Func<TEntity, bool>> where)
        {
            return await _dbs.Where(where).ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbs.FindAsync(id);
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbs.AddAsync(entity);
            await SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() =>
            {
                _dbs.Update(entity);
                SaveChangesAsync();
            });
        }


        private Task SaveChangesAsync() => _context.SaveChangesAsync();
        #endregion
    }
}
