using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Project.Models;

namespace MVC_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProjectContext _projectContext;



        public HomeController(ILogger<HomeController> logger, ProjectContext projectContext)
        {
            _logger = logger;
            _projectContext = projectContext;
        }

        public IActionResult Index()
        {
            //LAMBDA
            List<Product> productList = _projectContext.Products
                .Include(x => x.Category)
                .Include(x => x.Brand)
                .Where(x => x.Price > 10 && x.Name.Contains("a"))
                .Skip(0).Take(10)
                .OrderBy(x => x.Name)
                .ToList();
            return View(productList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
