using Sistema_De_Ventas.Models;
using Sistema_De_Ventas.Persistence;

namespace Sistema_De_Ventas.Repository
{
    public class ProductoRepository :RepositoryBase<Producto>, IProductoRepository
    {
        public ProductoRepository(ApplicationDbContext context): base(context)
        {
            
        }
    }
}
