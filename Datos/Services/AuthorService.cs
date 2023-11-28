using System;
using System.Linq;
using WebApplication1.Datos.Modelos;
using WebApplication1.Datos.ViewModel;

namespace WebApplication1.Datos.Services
{
    public class AuthorService
    {
        private AppDbContext _context;
        public AuthorService(AppDbContext context)
        {
            _context = context;
        }
        public void AddAuthor(AuthorVM author)
        {
            var _author = new Author()
            {
                fullName = author.FullName
            };
            _context.Authors.Add(_author);
            _context.SaveChanges();
        }
        public AuthorWithBooksVM GetAuthorWithBooks(int authorId)
        {
            var _author = _context.Authors.Where(n => n.iD == authorId).Select(n => new AuthorWithBooksVM()
            {
                FullName = n.fullName,
                BookTitles = n.Author_Libros.Select(n => n.libros.Titulo).ToList(),
            }).FirstOrDefault();
            return _author;
        }
    }
}
