﻿using System.ComponentModel.DataAnnotations;

namespace TeknikServisTakip.Models
{
    public class ResetPasswordViewModel
    {
        [Display(Name = "E-Posta Adresiniz")]
        [Required(ErrorMessage = "Lütfen e-posta adresinizi boş geçmeyiniz.")]
        [EmailAddress(ErrorMessage = "Lütfen uygun formatta e-posta giriniz.")]
        public string Email { get; set; }
    }
}
