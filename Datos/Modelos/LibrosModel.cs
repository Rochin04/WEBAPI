using System;
using System.Collections.Generic;

namespace WebApplication1.Datos.Modelos
{
    public class LibrosModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genero { get; set; }
        //public string Autor {  get; set; }
        public string CoverUrl { get; set; }
        public DateTime DateAdded { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public List<Author_Libros> Author_Libros { get; set; }
    }
}
