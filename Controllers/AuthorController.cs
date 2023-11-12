using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Datos.Modelos;
using WebApplication1.Datos.Services;
using WebApplication1.Datos.ViewModel;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private AuthorService _authorservice;
        public AuthorController(AuthorService authorservice)
        {
            _authorservice = authorservice;
        }
        [HttpPost("Add-Libros")]
        public IActionResult AddAuthor([FromBody] AuthorVM libros)
        {
            _authorservice.AddAuthor(libros);
            return Ok();
        }
    }
}
