using OrderManagementService.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementService.Application.Contracts.Persistence
{
   public interface IBaseRepository<TEntity,TKey> where TEntity : BaseEntity<TKey> where TKey:struct
    {
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>>? predicate);
        IQueryable<TProjection> GetAll<TProjection>(Expression<Func<TEntity, bool>>? predicate, Expression<Func<TEntity, TProjection>> expression);
        Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellation=default);
        Task<TProjection?> GetAsync<TProjection>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity,TProjection>> expression,CancellationToken cancellation=default);

        Task<bool> ExistAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellation = default);

        Task AddAsync(TEntity entity, CancellationToken cancellation = default);
        Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellation = default);
        IQueryable<TEntity> GetAllTracked(Expression<Func<TEntity, bool>>? predicate = null);
        void Remove(TEntity entity);


    }
}
