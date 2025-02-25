namespace Sistema_De_Ventas.DTO.Request
{
    public class ProductoRequestDto
    {
        public string nombre { get; set; } = default!;
        public string descripcion { get; set; } = default!;
        public decimal precio { get; set; }
        public int stock { get; set; }
    }
}
