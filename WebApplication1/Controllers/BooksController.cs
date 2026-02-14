using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        public class BookController : Controller
        {

            [HttpGet]
            public IActionResult GET(string kitapAdi)
            {
                return Ok(kitapAdi);
            }

            [HttpPost]
            public IActionResult POST(string yazar)
            {
                return Ok(yazar);
            }
        }
    }
}
