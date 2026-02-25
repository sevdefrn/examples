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
        ///Ülkeye göre yazarları getirir
        /// </summary>
        [HttpGet("country/{country}")]
        public async Task<ActionResult<IEnumerable<AuthorDto>>> GetByCountry(string country)
        {
            var authors = await _authorService.GetAuthorsByCountryAsync(country);
            return Ok(authors);
        }

        /// <summary>
        /// Yeni yazar ekler
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<AuthorDto>> Create([FromBody] CreateAuthorDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Name))
                return BadRequest(new { message = $"Yazar adı zorunludur." });
           
            var author = await _authorService.CreateAuthorsAsync(dto);
           
            return CreatedAtAction(nameof(GetById), new { id = author.Id }, author);
        }

        /// <summary>
        /// Yazar günceller
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<AuthorDto>> Update(int id, [FromBody] UpdateAuthorDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Name))
                return BadRequest(new { message = $"Yazar adı zorunludur." });

            var author = await _authorService.UpdateAuthorAsync(id, dto);

            if (author == null)
                return NotFound(new { message = $"Yazar bulunamadı. ID: {id}" });

            return Ok(author);
        }
       
        /// <summary>
        /// Yazarı siler
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _authorService.DeleteAuthorAsync(id);

            if (!result)
                return NotFound(new { message = $"Yazar bulunamadı. ID: {id}" });

            return NoContent();
        }
    }
}
