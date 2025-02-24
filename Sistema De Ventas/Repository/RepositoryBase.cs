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

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<TEntity>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
