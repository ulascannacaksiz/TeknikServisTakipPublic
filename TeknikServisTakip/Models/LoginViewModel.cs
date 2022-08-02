using System.ComponentModel.DataAnnotations;

namespace TeknikServisTakip.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Lütfen email girin")]
        public string email { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi girin")]
        public string password { get; set; }
    }
}
