﻿using FluentValidation;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;

namespace SUPERGASBRASIL_API.Validators
{
    public class Admin_InputValidator : AbstractValidator<Admin_InputModel>
    {
        public Admin_InputValidator()
        {
            RuleFor(a => a.Username)
                .NotEmpty()
                .WithMessage("O nome do Admin não pode ser vazio");
            RuleFor(a => a.Password)
                .NotEmpty()
                .WithMessage("A senha do Admin não pode ser vazia");
        }
    }
}
