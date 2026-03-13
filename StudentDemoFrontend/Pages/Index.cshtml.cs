using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using StudentDemoFrontend.Dto;
using StudentDemoFrontend.Pages;
using StudentDemoFrontend.Service;
using System.Net.Http;
using System.Text.Json;

namespace StudentDemoFrontend.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly HttpClient _httpClient;

        public List<BookDto> Books { get; set; } = new();
        public List<AuthorDto> Authors { get; set; } = new();

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient("api"); // BURASI
            _logger = logger;
        }

        public async Task OnGetAsync()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            // 1. KÝTAPLARI ÇEK
            var bookResponse = await _httpClient.GetAsync("https://localhost:7294/api/books");
            if (bookResponse.IsSuccessStatusCode)
            {
                var json = await bookResponse.Content.ReadAsStringAsync();
                Books = JsonSerializer.Deserialize<List<BookDto>>(json, options) ?? new();
            }
 
            // 2. YAZARLARI ÇEK (Kitaplardan baðýmsýz olarak çalýþýr)
            var authorResponse = await _httpClient.GetAsync("https://localhost:7294/api/authors");
            if (authorResponse.IsSuccessStatusCode)
            {
                var json = await authorResponse.Content.ReadAsStringAsync();
                Authors = JsonSerializer.Deserialize<List<AuthorDto>>(json, options) ?? new();
            }
        }
    }
}



