using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Datos.Modelos;
using WebApplication1.Datos.Services;
using WebApplication1.Datos.ViewModel;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private PublisherService _publisherService;
        public PublisherController(PublisherService publisherService)
        {
            _publisherService = publisherService;
        }
        [HttpPost("Add-Publisher")]
        public IActionResult AddAuthor([FromBody] PublisherVM libros)
        {
            _publisherService.AddPublisher(libros);
            return Ok();
        }
    }
}
