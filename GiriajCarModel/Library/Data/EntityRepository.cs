using System;
using System.Linq;
using System.Linq.Expressions;
using Core;
using Microsoft.EntityFrameworkCore;

namespace Data
{
	public class EntityRepository<TEntity> : IEntityRepository<TEntity>  where TEntity : BaseEntity
	{
        private readonly GirirajDbContext _girirajDbContext;

        public EntityRepository(GirirajDbContext girirajDbContext)
		{
            _girirajDbContext = girirajDbContext;
        }

        public async Task<IList<TEntity>> GetEntitiesAsync()
        {
            return await _girirajDbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<IList<TEntity>> GetEntitiesAsync(Expression<Func<TEntity,bool>> expression)
        {
            return await _girirajDbContext.Set<TEntity>().Where(expression).ToListAsync();
        }

        public async Task AddEntityAsync(TEntity entity)
        {
            await _girirajDbContext.Set<TEntity>().AddAsync(entity);
            await _girirajDbContext.SaveChangesAsync();
        }

        public void UpdateEntity(TEntity entity)
        {
            _girirajDbContext.Update(entity);
        }

        public void DeleteEntity(TEntity entity)
        {
            _girirajDbContext.Remove(entity);
        }
    }
}

