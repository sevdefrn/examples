using StudentDemoFrontend.Dto;
using System.Text.Json;

namespace StudentDemoFrontend.Service
{
    public class BookService
    {
        private readonly HttpClient _client;

        public BookService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<BookDto>> GetBooks()
        {
            var response = await _client.GetAsync("api/books");

            var json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<BookDto>>(json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
        }
    }
}
