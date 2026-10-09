namespace WebAPI_CRUD.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        
        // Propiedad de navegación
        public List<Producto> Productos { get; set; } = new List<Producto>();
    }
}
