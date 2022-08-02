using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CustomerValidator: AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Ad boş olamaz");
            RuleFor(x => x.CustomerSurname).NotEmpty().WithMessage("Soyad boş olamaz");
            RuleFor(x => x.CustomerEmail).NotEmpty().WithMessage("Email boş olamaz");
            RuleFor(x => x.CustomerPhone).NotEmpty().WithMessage("Telefon boş olamaz");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Adres boş olamaz");

            RuleFor(x => x.CustomerEmail).EmailAddress().WithMessage("Gerçerli bir mail adresi girin");
            RuleFor(x => x.CustomerPhone).Length(11).WithMessage("Telefon numarsı 11 haneli olmalıdır");
        }
    }
}
