using FluentValidation;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;

namespace SUPERGASBRASIL_API.Validators
{
    public class ClientNatural_InputValidator : AbstractValidator<ClientNatural_InputModel>
    {
        public ClientNatural_InputValidator()
        {
            RuleFor(a => a.Name)
                .NotEmpty()
                .WithMessage("O nome da empresa não pode ser vazio");

            RuleFor(a => a.Age)
                .NotEmpty()
                .WithMessage("A idade não pode ser vazio")
                .GreaterThanOrEqualTo(18).WithMessage("A idade deve ser maior ou igual a 18 anos.")
                .LessThanOrEqualTo(60).WithMessage("A idade deve ser menor ou igual a 60 anos.");

            RuleFor(a => a.DateOfBirth)
                .NotEmpty()
                .WithMessage("A Data de nascimento não pode ser vazio")
                .Matches(@"^\d{2}/\d{2}/\d{4}$").WithMessage("A data de nascimento deve estar no formato dd/MM/yyyy.");

            RuleFor(a => a.CPF)
                .NotEmpty().WithMessage("O CPF não pode estar vazio.")
                .Matches(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$").WithMessage("O formato do CPF está incorreto.");
        }
    }
}
