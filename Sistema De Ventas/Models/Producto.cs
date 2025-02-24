namespace Sistema_De_Ventas.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string nombre { get; set; } = default!;
        public string descripcion { get; set; } = default!;
        public decimal precio { get; set; }
        public int stock { get; set; }

    }
}
