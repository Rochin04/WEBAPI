using System.Collections.Generic;

namespace WebApplication1.Datos.Modelos
{
    public class Author_Libros
    {
        public int Id { get; set; }
        public int IdLibro {  get; set; }
        public LibrosModel libros { get; set; }
        public int AuthorId { get; set; }
        public Author Author {  get; set; }
        public List<Author_Libros> Author_Libross { get; set; }

    }
}
