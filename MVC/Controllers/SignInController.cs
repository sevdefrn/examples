using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using MVC.Models.ViewModels;

namespace MVC.Controllers
{
    public class SignInController : Controller
    {
        private static List<SignInViewModels> users = new List<SignInViewModels>
        {
            new SignInViewModels{userName="SevdeFrn" , Password="131006"}
        };

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        //Kullanıcı bul ve cookies oluştur ve Kullanıcı varsa hoşgeldiniz mesajı göster. Kullanıcı yoksa bilgileri kontrol et
        [HttpPost]
        public IActionResult Create(SignInViewModels model , bool rememberMe)
        {
            var user = users.FirstOrDefault(x => x.userName == model.userName && x.Password == model.Password);
            if (user != null)
            {
                //Kullanıcı bulundu, cookie oluştur
                Response.Cookies.Append(user.userName, "true", new CookieOptions
                {
                    Expires = rememberMe
                    ? DateTimeOffset.Now.AddMinutes(60)   // BENİ HATIRLA
                    : DateTimeOffset.Now.AddMinutes(20)
                });
                ViewBag.Message = "Hoşgeldiniz " + model.userName;
                return RedirectToAction("Index", "Product");

            }
            //KUllanıcı varsa COOkies hoçgeldiniz mesajı göster
            if (Request.Cookies[model.userName] != null)
            {
                ViewBag.Message = "Hoşgeldiniz " + model.userName;
                return RedirectToAction("Index", "Product");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Erorr()
        {
            //Kullanıcı bulanamadı ve yanılış giriş yaptı
            ViewBag.Message = "Kullanıcı adı veya şifre yanlış.";
            return RedirectToAction("Erorr", "SignIn");
        }

        //Kullanıcı varsa cookies çıkılı yap
        [HttpPost]
        public IActionResult Logout(string userName)
        {
            if (Request.Cookies[userName] != null)
            {
                Response.Cookies.Delete(userName);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
