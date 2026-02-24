using Microsoft.AspNetCore.Mvc;
using StudentDemo.Core.DTOs;
using StudentDemo.Core.Services;

namespace StudentDemo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        /// <summary>
        /// Tüm yazarları getirir
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuthorDto>>> GetAll() 
        {
            var authors = await _authorService.GetAllAuthorsAsync();
            return Ok(authors);
        }

        /// <summary>
        /// ID'ye göre yazar getirir
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<AuthorDto>> GetById(int id)
        {
            var author = await _authorService.GetAuthorByIdAsync(id);
            
            if(author==null)
                return NotFound(new {message=$"Yazar bulunamadı. ID: {id}"});
            
            return Ok(author);
        }

        ///<summary>
        ///Yazarın kitaplarını getirir
        /// </summary>
        [HttpGet("{id}/books")]
        public async Task<ActionResult<AuthorWithBooksDto>> GetAuthorWithBooks(int id)
        {
            var author = await _authorService.GetAuthorWithBooksAsync(id);
            
            if(author==null)
                return NotFound(new {message=$"Yazar bulunamadı. ID: {id}"});

            return Ok(author);
        }

        ///<summary>
        ///
        /// </summary>

    }
}
