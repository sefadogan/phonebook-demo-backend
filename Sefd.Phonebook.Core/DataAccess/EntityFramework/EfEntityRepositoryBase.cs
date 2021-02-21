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
        private readonly DbSet<TEntity> _dbSet;
        #endregion

        #region Constructors
        public EfEntityRepositoryBase()
        {
            _context = new TContext();
            _dbSet = _context.Set<TEntity>();
        }
        #endregion

        #region Methods
        public async Task<ICollection<TEntity>> ListAsync(
            Expression<Func<TEntity, bool>> where = null,
            params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            if (includes != null && includes.Length > 0)
            {
                foreach (Expression<Func<TEntity, object>> include in includes)
                {
                    query = query.Include(include);
                }
            }

            return where == null 
                ? await query.ToListAsync() 
                : await query.Where(where).ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() =>
            {
                _dbSet.Update(entity);
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
            });
        }

        public async Task UpdatePartialAsync(int id, object obj)
        {
            var entity = await GetByIdAsync(id);
            _context.Entry(entity).CurrentValues.SetValues(obj);

            await SaveChangesAsync();
        }

        private Task SaveChangesAsync() => _context.SaveChangesAsync();
        #endregion
    }
}
