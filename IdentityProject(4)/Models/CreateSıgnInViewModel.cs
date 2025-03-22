using System.ComponentModel.DataAnnotations;

namespace IdentityProject_4_.Models
{
    public class CreateSıgnInViewModel
    {
        [Display(Name = " Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Girin")]
        public string Username { get; set; }


        [Display(Name = " Şifre")]
        [Required(ErrorMessage = "Lütfen Şifrenizi  Girin")]
        public string Password { get; set; }

    }
}
