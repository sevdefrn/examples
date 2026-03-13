using StudentDemoFrontend.Dto;
using System.Text.Json;

namespace StudentDemoFrontend.Service
{
   
        public class AuthorService
        {
            private readonly HttpClient _client;

            public AuthorService(HttpClient client)
            {
                _client = client;
            }

            public async Task<List<AuthorDto>> GetBooks()
            {
                var response = await _client.GetAsync("api/books");

                var json = await response.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<List<AuthorDto>>(json,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    
}
