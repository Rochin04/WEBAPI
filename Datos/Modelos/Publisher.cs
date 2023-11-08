using System.Collections.Generic;

namespace WebApplication1.Datos.Modelos
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<LibrosModel> Libros { get; set; }
    }
}
