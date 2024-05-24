using FluentValidation;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;

namespace SUPERGASBRASIL_API.Validators
{
    public class Employee_InputValidator : AbstractValidator<Employees_InputModel>
    {
        public Employee_InputValidator()
        {
            RuleFor(a => a.Name)
                .NotEmpty()
                .WithMessage("O nome do funcionario não pode ser vazio");

            RuleFor(a => a.Cpf)
                .NotEmpty().WithMessage("O CPF não pode estar vazio.")
                .Matches(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$").WithMessage("O formato do CPF está incorreto.");

            RuleFor(a => a.Salary)
                .NotEmpty()
                .WithMessage("O Salario não pode ser vazio");

            RuleFor(a => a.Position)
                .NotEmpty()
                .WithMessage("O cargo não pode ser vazio");

            RuleFor(a => a.DateOfBirth)
                .NotEmpty()
                .WithMessage("A data de nascimento não pode ser vazio");
        }

    }
}
