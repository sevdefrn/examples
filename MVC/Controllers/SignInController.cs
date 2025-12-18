using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using MVC.Models.ViewModels;

namespace MVC.Controllers
{
    public class SignInController : Controller
    {
        private static List<SignInViewModels> users = new List<SignInViewModels>
    {
        new SignInViewModels { userName = "SevdeFrn", Password = "131006" }
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
                return RedirectToAction("Index", "Product");
            }

            return View();
        }

        // Kullanıcı giriş kontrolü ve rbeni hatırla kısmı
        [HttpPost]
        public IActionResult Create(SignInViewModels model)
        {
            var user = users.FirstOrDefault(x =>
                x.userName == model.userName &&
                x.Password == model.Password);

            if (user != null)
            {
                Response.Cookies.Append("LoginUser", user.userName, new CookieOptions
                {
                    Expires = model.RememberMe
                    //beni hatırla buttonuna basınıca 60 dakkika
                        ? DateTimeOffset.Now.AddMinutes(60)   
                        //buttona basılmassa 20 dakika
                        : DateTimeOffset.Now.AddMinutes(20),
                    HttpOnly = true
                });

                return RedirectToAction("Index", "Product");
            }

            TempData["Message"] = "Kullanıcı adı veya şifre yanlış.";
            return RedirectToAction("Erorr");
        }

        //Kullanıcı yanlış girdiğinde error mesajı
        [HttpGet]
        public IActionResult Erorr()
        {
            ViewBag.Message = TempData["Message"];
            return View();
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
