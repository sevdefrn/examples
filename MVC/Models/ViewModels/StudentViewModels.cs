using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models.ViewModels
{
    public class StudentViewModels
    {
        [Required(ErrorMessage ="Bu alan boş geçilemez")]
        [DisplayName("Ad Soyad")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Bu alan boş geçilemez")]
        [EmailAddress(ErrorMessage ="E-posta formatı doğru değil")]
        [DisplayName("E-posta")]
        public string Email {  get; set; }

        [Range(18,60,ErrorMessage ="Yaş 18 ila 60 arasında olmalıdır")]
        [DisplayName("Yaş")]
        public int Age {  get; set; }
    }
}
