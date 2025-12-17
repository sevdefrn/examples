using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models.ViewModels
{
    public class SignInViewModels
    {
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        [DisplayName("Kullanıcı Adı")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        [DisplayName("Şifre")]
        public string Password {  get; set; } 

        public bool RememberMe { get; set; }
    }
}
