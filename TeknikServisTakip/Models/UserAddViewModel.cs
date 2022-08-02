using System.ComponentModel.DataAnnotations;

namespace TeknikServisTakip.Models
{
    public class UserAddViewModel
    {
        [Required(ErrorMessage="İsim boş olamaz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyisim boş olamaz")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Email boş olamaz")]
        [EmailAddress(ErrorMessage = "Lütfen uygun formatta e-posta giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı boş olamaz")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Şifre boş olamaz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Telefon boş olamaz")]
        public string Phone { get; set; }
    }
}
