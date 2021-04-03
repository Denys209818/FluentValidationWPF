using Cat.Application.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cat.Application.Services
{
    public class CatValidator : AbstractValidator<CatModel>
    {
        public CatValidator()
        {
            RuleFor(cat => cat.Name)
                .NotEmpty().WithMessage("Поле не може бути пустим!");
            RuleFor(cat => cat.Age).Must(ValidAge)
                .WithMessage("Вік введено некоректно!");
            RuleFor(cat => cat.ImgPath)
                .NotEmpty().WithMessage("Поле не можу бути пустим!");
            RuleFor(cat => cat.Price)
                .Must(ValidPrice).WithMessage("Ціна введена некоректно!");
            RuleFor(cat => cat.Birthday)
                .NotNull().WithMessage("Дата народження не введена!");
        }
        public static bool ValidAge(int age) 
        {
            if (age < 30 && age > 0) 
            {
                return true;
            }
            return false;
        }
        public static bool ValidPrice(decimal price) 
        {
            if (price > 0)
            {
                return true;
            }
                return false;
        }
    }
}
