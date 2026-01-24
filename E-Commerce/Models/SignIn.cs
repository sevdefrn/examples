using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class SignIn
    {
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        [DisplayName("Kullanıcı Adı")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        [DisplayName("Şifre")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
