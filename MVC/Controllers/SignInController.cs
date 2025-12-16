using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using MVC.Models.ViewModels;

namespace MVC.Controllers
{
    public class SignInController : Controller
    {
        private static List<SignInViewModels> _users = new List<SignInViewModels>
        {
            new SignInViewModels{FullName="Sevde FURUNCU", Email="furuncusvd@outlook.com", Password="131006"}
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
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Users(SignInViewModels model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            _users.Add(model);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Users(string FullName, string Email, string Password)
        {
            var users = _users.FirstOrDefault(x => x.FullName == FullName && x.Email == Email && x.Password == Password);
            if (users != null)
            {
                return RedirectToAction("Index", "Product");
            }
            return RedirectToAction("Index", "Home");

        }

        public IActionResult Login()
        {
                return View();
        }

        [HttpPost]
        public IActionResult Login(SignInViewModels model)
        {
            var users = _users.FirstOrDefault(x =>x.FullName==model.FullName && x.Email == model.Email && x.Password == model.Password);

            if (users != null)
            {
                CookieOptions options = new CookieOptions
                {
                    Expires = DateTime.Now.AddMinutes(30)
                };
                Response.Cookies.Append("FullName", users.FullName, options);
                return RedirectToAction("Index", "Product");
            }
            return View();
        }

    }
}
