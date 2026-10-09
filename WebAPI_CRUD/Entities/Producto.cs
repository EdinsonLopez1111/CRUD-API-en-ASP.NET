namespace WebAPI_CRUD.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        
        // Clave Foránea
        public int CategoriaId { get; set; }
        
        // Propiedad de navegación
        public Categoria? Categoria { get; set; }
    }
}
