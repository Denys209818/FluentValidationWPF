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
                .NotEmpty().WithMessage("Поле \"Назва\" не може бути пустим!");
            RuleFor(cat => cat.ImgPath)
                .NotEmpty().WithMessage("Поле \"Силка на зображення\" не може бути пустим!");
            RuleFor(cat => cat.Details)
                .NotEmpty().WithMessage("Поле \"Деталі\" не може бути пустим");
            RuleFor(cat => cat.Age)
                .NotEmpty().WithMessage("Поле \"Вік\" введено не коректно!");
            RuleFor(cat => cat.Price)
                .NotEmpty().WithMessage("Поле \"Ціна\" введено не коректно!");
            RuleFor(cat => cat.Age)
                .Must(ValidAge).WithMessage("Вік вказаний некоректно!");
            RuleFor(cat => cat.Price).Must(ValidPrice)
                .WithMessage("Ціна вказана некоректно!");
        }
        public static bool ValidAge(int age)
        {
            if (age < 30 && age >= 0)
            {
                return true;
            }
            return false;
        }
        public static bool ValidPrice(decimal price)
        {
            if (price >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
