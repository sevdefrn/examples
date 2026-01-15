using System.Diagnostics;
using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProjectContext _projetContext;

        public HomeController(ILogger<HomeController> logger, ProjectContext projectContext)
        {
            _logger = logger;
            _projetContext = projectContext;
        }

        public IActionResult Index()
        {
            // sql den verileri çekip liste haline getiriyor
            var categories = _projetContext.Categories.ToList();
            var products = _projetContext.Products
                .Include(p => p.ProductImages)
                .ToList();
            return View((categories, products));
        }

        public IActionResult Privacy()
        {
            return View();
        }



        public IActionResult List(int categoryId)
        {
            // sql den verileri çekip liste haline getiriyor
            var product = _projetContext.Products
                .Include(p => p.ProductImages)
                .Where(x => x.CategoryId == categoryId)
                .Where(x => x.IsActive)
                .ToList();
            return View(product);
        }

        public IActionResult Detail(int id)
        {
            var product = _projetContext.Products
                .Include(p => p.ProductImages)
                .Include(p => p.ProductColors)
                .Include(p => p.ProductProperties)
                .Include(p => p.ProductSizes)
                .FirstOrDefault(x => x.Id == id && x.IsActive);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
