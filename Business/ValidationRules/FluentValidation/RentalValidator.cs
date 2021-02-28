using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.CarId).GreaterThan(0);
            RuleFor(r => r.CustomerId).GreaterThan(0);
            RuleFor(r => r.RentDate).NotEmpty();
            RuleFor(r => r.ReturnDate).GreaterThanOrEqualTo(r=>r.RentDate).When(r=>r.ReturnDate.HasValue).WithMessage("Girilen tarih bilgileri uyuşmamaktadır.");

        }
    }
}
