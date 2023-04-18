using System;
using System.Linq.Expressions;
using Core;

namespace Data
{
	public interface IEntityRepository<TEntity> where TEntity : BaseEntity
	{
        Task<IList<TEntity>> GetEntitiesAsync();

        Task<IList<TEntity>> GetEntitiesAsync(Expression<Func<TEntity, bool>> expression);

        void UpdateEntity(TEntity entity);

        void DeleteEntity(TEntity entity);

        Task AddEntityAsync(TEntity entity);

    }
}

