using Microsoft.EntityFrameworkCore;
using OrderManagementService.Application.Contracts.Persistence;
using OrderManagementService.Domain.Common;
using OrderManagementService.Infrastructure.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Infrastructure.Repository
{
    public class BaseRepository<TEntity, TKey>(MainDbContext mainDb) : IBaseRepository<TEntity, TKey> where TEntity : BaseEntity<TKey> where TKey : struct
    {
        private readonly DbSet<TEntity> dbSet = mainDb.Set<TEntity>();

        public async Task AddAsync(TEntity entity, CancellationToken cancellation = default)
        {
            await dbSet.AddAsync(entity, cancellation);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellation = default)
        {
            await dbSet.AddRangeAsync(entities, cancellation);
        }

        public async Task<bool> ExistAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellation = default)
        {
           return await dbSet.AnyAsync(predicate, cancellation);
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>>? predicate)
        {
            var entities = dbSet
                .AsNoTracking()
                .AsQueryable();
            if(predicate != null) 
                entities= entities.Where(predicate);
            return entities;
        }

        public IQueryable<TProjection> GetAll<TProjection>(Expression<Func<TEntity, bool>>? predicate, Expression<Func<TEntity, TProjection>> expression)
        {
            var entities = dbSet
                .AsNoTracking()
                .AsQueryable();
            if (predicate != null)
                entities = entities.Where(predicate);
            return entities.Select(expression);
        }

        public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellation = default)
        {
            var entity = await dbSet
                .Where(predicate)
                .FirstOrDefaultAsync(cancellationToken: cancellation);
            return entity;
        }

        public async Task<TProjection?> GetAsync<TProjection>(Expression<Func<TEntity, bool>> predicate, System.Linq.Expressions.Expression<Func<TEntity, TProjection>> expression, CancellationToken cancellation = default)
        {
            var entity = await dbSet
                .AsNoTracking()
                .Where(predicate)
                .Select(expression)
                .FirstOrDefaultAsync(cancellationToken: cancellation);
            return entity;
        }
        public IQueryable<TEntity> GetAllTracked(Expression<Func<TEntity, bool>>? predicate = null)
        {
            IQueryable<TEntity> query = dbSet;

            if (predicate is not null)
                query = query.Where(predicate);

            return query;
        }

        public void Remove(TEntity entity)
        {
            dbSet.Remove(entity);
        }
    }
}
