using WebApplication1.Datos.ViewModel;
using WebApplication1.Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Security.Policy;

namespace WebApplication1.Datos.Services
{
    public class LibrosService
    {
        private AppDbContext _context;
        public LibrosService(AppDbContext context)
        {
            _context = context;
        }
        public void AddLibrosWithAuthors(LibrosVM libros)
        {
            var _libro = new LibrosModel()
            {
                Titulo = libros.Titulo,
                Descripcion = libros.Descripcion,
                IsRead = libros.IsRead,
                DateRead = libros.DateRead,
                Rate = libros.Rate,
                Genero = libros.Genero,
                //Autor = libros.Autor,
                CoverUrl = libros.CoverUrl,
                DateAdded = DateTime.Now,
                PublisherId = libros.PublisherId
            };
            _context.Libros.Add(_libro);
            _context.SaveChanges();
            foreach(var id in libros.AuthorId)
            {
                var _libros_author = new Author_Libros()
                {
                    IdLibro = _libro.Id,
                    AuthorId = id
                };
                _context.Author_Libro.Add(_libros_author);
                _context.SaveChanges();
            }
        }
        public List<LibrosModel> GetAllLbrs() => _context.Libros.ToList();
        //public LibrosModel GetlibsId(int Id) => _context.Libros.FirstOrDefault(n => n.Id == Id);
        //public void
        //public LibrosModel UpdateLibrosId(int Id, LibrosVM libros)
        public BookWithAuthorsVM GetBookById(int bookid)
        {
            /*var _libros = _context.Libros.FirstOrDefault(n => n.Id == Id);
            if(_libros != null)
            {
                _libros.Titulo = libros.Titulo;
                _libros.Descripcion = libros.Descripcion;
                _libros.IsRead = libros.IsRead;
                _libros.DateRead = libros.DateRead;
                _libros.Rate = libros.Rate;
                _libros.Genero = libros.Genero;
                //_libros.Autor = libros.Autor;
                _libros.CoverUrl = libros.CoverUrl;
                _libros.DateAdded = DateTime.Now;
                _context.SaveChanges() ;
            }
            return _libros;*/
            var _booksWithAuthors = _context.Libros.Where(n => n.Id == bookid).Select(book => new BookWithAuthorsVM()
            {
                Titulo = book.Titulo,
                Descripcion = book.Descripcion,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Rate = book.Rate,
                Genero = book.Genero,
                CoverUrl = book.CoverUrl,
                PublisherName = book.Publisher.Name,
                AutorNames = book.Author_Libros.Select(n => n.Author.fullName).ToList()
            }).FirstOrDefault();
            return _booksWithAuthors;
        }
        public void DeleteLibros(int Id)
        {
            var _Libro = _context.Libros.FirstOrDefault(n => n.Id == Id);
            if(_Libro != null)
            {
                _context.Libros.Remove(_Libro);
                _context.SaveChanges();
            }
        }
        public LibrosModel UpdateBookByID(int bookid, LibrosVM book)
        {
            var _book = _context.Libros.FirstOrDefault(n => n.Id == bookid);
            if (_book != null)
            {
                _book.Titulo = book.Titulo;
                _book.Descripcion = book.Descripcion;
                _book.IsRead = book.IsRead;
                _book.DateRead = book.DateRead;
                _book.Rate = book.Rate;
                _book.Genero = book.Genero;
                _book.CoverUrl = book.CoverUrl;

                _context.SaveChanges();
            }
            return _book;
        }
        public void DeleteBookByID(int bookid)
        {
            var _book = _context.Libros.FirstOrDefault(n => n.Id == bookid);
            if (_book != null)
            {
                _context.Libros.Remove(_book);
                _context.SaveChanges();
            }
        }
    }
}
