namespace WebApplication2.Models
{
    public class Producto
    {
        public int Id { get; set; }          // Llave primaria
        public required string Nombre { get; set; }   // Nombre del producto
        public decimal Precio { get; set; }  // Precio del producto

    }
}
