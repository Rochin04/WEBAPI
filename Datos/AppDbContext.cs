using Microsoft.EntityFrameworkCore;
using WebApplication1.Datos.Modelos;
using WebApplication1.Datos.Services;
using WebApplication1.Datos.ViewModel;
using WebApplication1.Controllers;
using WebApplication1.Migrations;

namespace WebApplication1.Datos
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author_Libros>().HasOne(b => b.libros).WithMany(ba => ba.Author_Libros).HasForeignKey(bi => bi.IdLibro);
            modelBuilder.Entity<Author_Libros>().HasOne(b => b.Author).WithMany(ba => ba.Author_Libros).HasForeignKey(bi => bi.AuthorId);
        }
        public DbSet<LibrosModel> Libros { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Author_Libros> Author_Libro { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}
