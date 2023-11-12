using System.Collections.Generic;

namespace WebApplication1.Datos.Modelos
{
    public class Author
    {
        public int iD { get; set; }
        public string fullName { get; set; }
        public List<Author_Libros> Author_Libros { get; set; }
    }
}
