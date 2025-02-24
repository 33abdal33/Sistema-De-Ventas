using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema_De_Ventas.Models;

namespace Sistema_De_Ventas.Persistence.Configuration
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.Property(p => p.nombre).HasMaxLength(200);
            builder.Property(p => p.descripcion).HasMaxLength(500);
            
        }
    }
}
