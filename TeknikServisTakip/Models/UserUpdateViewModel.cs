using System.ComponentModel.DataAnnotations;

namespace TeknikServisTakip.Models
{
    public class UserUpdateViewModel
    {
        [Required(ErrorMessage = "İsim boş olamaz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soysim boş olamaz")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Telefon boş olamaz")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email boş olamaz")]
        public string Email { get; set; }
        public string Password { get; set; }
        public int id { get; set; }
    }
}
