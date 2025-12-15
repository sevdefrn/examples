using Microsoft.AspNetCore.Mvc;
using MVC.Models.ViewModels;

namespace MVC.Controllers
{
    public class SignInController : Controller
    {
        private static List<SignInViewModels> _users = new List<SignInViewModels>
        {
            new SignInViewModels{FullName="Sevde FURUNCU", Email="furuncusvd@outlook.com", Password=20251310}
        };
        public IActionResult Index()
        {
            return View(_users);
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
            return RedirectToAction("Users", "SignIn");
        }

        public IActionResult Users(string fullname, string email , double password)
        {
            var user = _users.FirstOrDefault(x => x.FullName == fullname && x.Email == email && x.Password == password);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        public IActionResult Users(SignInViewModels model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("Users", "SignIn");
        }


    }
}
