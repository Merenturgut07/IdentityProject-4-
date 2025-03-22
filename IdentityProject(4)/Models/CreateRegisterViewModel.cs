using System.ComponentModel.DataAnnotations;

namespace IdentityProject_4_.Models
{
    public class CreateRegisterViewModel
    {
        [Display(Name = "İsim")]
        [Required(ErrorMessage = "Lütfen İism Bilgisini Giriniz")]
        public string Name { get; set; }


        [Display(Name = " Soyad")]
        [Required(ErrorMessage = "Lütfen  Soyad Bilgisini Giriniz")]
        public string Surname { get; set; }


        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen Şifre Giriniz")]
        public string Password { get; set; }


        [Display(Name = "Şifre Tekrarı")]
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")] /*(Şifrelerin aynı olup olmadığını tutacak Compore methodu)*/
        public string ConfirmPassword { get; set; }



        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage = "Lütfen Mail  Giriniz")]
        public string Mail { get; set; }



        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz")]
        public string UserName { get; set; }


    }
}
