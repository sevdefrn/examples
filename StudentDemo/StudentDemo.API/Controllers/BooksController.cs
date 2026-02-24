using Microsoft.AspNetCore.Mvc;
using StudentDemo.Core.DTOs;
using StudentDemo.Core.Services;

namespace StudentDemo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;


        /// <summary>
        /// Tüm kitapları getirir
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetAll()
        {
            var books = await _bookService.GetAllBooksAsync();
            return Ok(books);
        }

        /// <summary>
        /// ID'ye göre kitap getirir
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<BookDto>> GetById(int id)
        {
            var book = await _bookService.GetBookByIdAsync(id);
            if (book == null)
                return NotFound(new { message = $"Kitap bulanamadı. ID: {id}" });
            return Ok(book);
        }

        /// <summary>
        /// ISBN'e göre kitap getirir
        /// </summary>
        [HttpGet("isbn/{isbn}")]
        public async Task<ActionResult<BookDto>> GetByIsbn(string isbn)
        {
            var book = await _bookService.GetBookByIsbnAsync(isbn);
            if (book == null)
                return NotFound(new { message = $"Kitap bulunamadı. ISBN:{isbn}" });

            return Ok(book);
        }

        /// <summary>
        /// Yeni kitap ekler
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<BookDto>> Create([FromBody] CreateBookDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Title))
                return BadRequest(new { message = $"Kitap başlığı zorunludur." });

            var book = await _bookService.CreateBookAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = book.Id }, book);
        }


        /// <summary>
        /// Kitabı günceller
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<BookDto>> Update(int id, [FromBody] UpdateBookDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Title))
                return BadRequest(new { message = $"Kitap başlığı zorunludur." });

            var book = await _bookService.UpdateBookAsync(id, dto);
            if (book == null)
                return NotFound(new { message = $"Kitap bulunamadı. ID: {id}" });
            return Ok(book);
        }

        ///<summary>
        ///Kitabı siler
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _bookService.DeleteBookAsync(id);
            if(!result)
                return NotFound(new {message=$"Kitap bulunamadı. ID: {id}" });

            return NoContent();
        }
    }
}
