using System.ComponentModel.DataAnnotations;

namespace TeknikServisTakip.Models
{
    public class UpdatePasswordViewModel
    {
        [Display(Name = "Yeni Şifre")]
        [Required(ErrorMessage = "Lütfen şifreyi boş geçmeyiniz.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Token { get; set; }
        public string Email { get; set; }
    }
}
