using Sistema_De_Ventas.Models;

namespace Sistema_De_Ventas.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        Task<ICollection<TEntity>> GetAsync();
        Task<TEntity> GetAsync(int id);
        Task<int> AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(int id);

    }
}
