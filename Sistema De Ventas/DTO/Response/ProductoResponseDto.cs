namespace Sistema_De_Ventas.DTO.Response
{
    public class ProductoResponseDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = default!;
        public string Descripcion { get; set; } = default!;
        public decimal Precio { get; set; }
        public int Stock { get; set; }

    }
}
