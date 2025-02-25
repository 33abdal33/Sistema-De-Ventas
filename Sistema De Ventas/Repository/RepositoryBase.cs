using Microsoft.EntityFrameworkCore;
using Sistema_De_Ventas.Models;

namespace Sistema_De_Ventas.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        protected readonly DbContext context;
        public RepositoryBase(DbContext context)
        {
            this.context = context;
        }
        public virtual async Task<int> AddAsync(TEntity entity)
        {
            await context.Set<TEntity>().AddAsync(entity);
            await context.SaveChangesAsync();
            return entity.Id;
        }

        public virtual async Task DeleteAsync(int id)
        {
            var item = await GetAsync(id);
            if(item is not null)
            {
                context.Set<TEntity>().Remove(item);
                await context.SaveChangesAsync();
            }
        }

        public virtual async Task<ICollection<TEntity>> GetAsync()
        {
            return await context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public virtual async Task<TEntity?> GetAsync(int id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            await context.SaveChangesAsync();
        }
    }
}
