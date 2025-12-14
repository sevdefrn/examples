using Microsoft.AspNetCore.Mvc;
using MVC.Models.ViewModels;

namespace MVC.Controllers
{
    public class SignInController : Controller
    {
        private static List<SignInViewModels>_users = new List<SignInViewModels>
        {
            new SignInViewModels{FullName="Sevde FURUNCU", Email="furuncusvd@outlook.com", Password=20251310}
        };
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SignInViewModels model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("Index","Home");
        }
    }
}
