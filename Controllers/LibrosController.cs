using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Datos.Services;
using WebApplication1.Datos.ViewModel;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        public LibrosService _librosService;
        public LibrosController(LibrosService librosService)
        {
            _librosService = librosService;
        }
        [HttpGet("get-all-libros")]
        public IActionResult GetAllLbrs()
        {
            var allbook = _librosService.GetAllLbrs();
                return Ok(allbook);
        }
        [HttpGet("get-by-id/{Id}")]
        public IActionResult GetForID(int Id)
        {
            var libros = _librosService.GetlibsId(Id);
            return Ok(libros);
        }
        [HttpPost("add-libros-with-autrhors")]
        public IActionResult AddLibros([FromBody]LibrosVM libros)
        {
            _librosService.AddLibrosWithAuthors(libros);
            return Ok();
        }
        [HttpPut("update-by-id/{Id}")]
        public IActionResult UpdateLibrosId(int Id, [FromBody]LibrosVM libros)
        {
            var updateLibros = _librosService.UpdateLibrosId(Id, libros);
            return Ok(updateLibros);
        }
        [HttpDelete("delete-by-Id/{Id}")]
        public IActionResult DeleteLibro(int Id) 
        {
            _librosService.DeleteLibros(Id);
            return Ok();
        }
    }
}
