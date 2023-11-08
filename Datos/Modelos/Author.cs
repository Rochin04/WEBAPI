using System.Collections.Generic;

namespace WebApplication1.Datos.Modelos
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<Author_Libros> Author_Libros { get; set; }
    }
}
