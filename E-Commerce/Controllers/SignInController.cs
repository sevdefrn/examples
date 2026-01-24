using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    public class SignInController : Controller
    {
        private static List<SignIn> users = new List<SignIn>
        {
            new SignIn {userName= "Sevde Furuncu", Password="131006"}
        };
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            // Cookie varsa otomatik giriş

            if (Request.Cookies["LoginUser"] != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Create(SignIn model)
        {
            // Kullanıcı giriş kontrolü ve rbeni hatırla kısmı

            var user = users.FirstOrDefault(x => x.userName == model.userName && x.Password == model.Password);

            if (user != null)
            {
                Response.Cookies.Append("LoginUser", user.userName, new CookieOptions
                {
                    Expires = model.RememberMe
                    // 60 DAKİKA
                    ? DateTimeOffset.Now.AddMinutes(60)
                    // 20 DAKİKA  
                    : DateTimeOffset.Now.AddMinutes(20),
                    HttpOnly = true
                });

                return RedirectToAction("Index", "Home");

            }
            TempData["Message"] = "Kullancı adı ya da şifre yanlış. Tekrar deneyiniz.";
            return RedirectToAction("Index", "Home");
        }

        // Kullanıcı varsa çıkış buttonu
        [HttpPost]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("LoginUser");
            return RedirectToAction("Index", "Home");
        }

    }
}
