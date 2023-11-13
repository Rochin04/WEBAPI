using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.Datos.Modelos;
using System.Linq;
using System;

namespace WebApplication1.Datos
{
    public class AppDbInitialer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if(!context.Libros.Any())
                {
                    context.Libros.AddRange(new LibrosModel()
                    {
                        Titulo = "1st book Titulo",
                        Descripcion = "1st book description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genero = "Biography",
                        CoverUrl = "http...",
                        DateAdded = DateTime.Now,
                    },
                    new LibrosModel
                    {
                        Titulo = "2st book Titulo",
                        Descripcion = "2st book description",
                        IsRead = true,
                        Genero = "Biography",
                        CoverUrl = "http...",
                        DateAdded = DateTime.Now,
                    }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
