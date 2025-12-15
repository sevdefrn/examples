using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models.ViewModels
{
    public class SignInViewModels
    {
        [Required(ErrorMessage ="Bu alan boş geçilemez")]
        [DisplayName("Ad Soyad")]
        public string FullName { get; set; }

        [Required(ErrorMessage ="Bu alan boş geçilemez")]
        [EmailAddress(ErrorMessage ="E-posta formatı doğru değil")]
        [DisplayName("E-posta")]
        public string Email {  get; set; }

        [Required(ErrorMessage ="Lütfen şifrenizi giriniz")]
        [DisplayName("Şifre")]
        public double Password {  get; set; }
    }
}
