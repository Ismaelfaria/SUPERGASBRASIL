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

            RuleFor(a => a.CPF)
                .NotEmpty().WithMessage("O CPF não pode estar vazio.")
                .Matches(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$").WithMessage("O formato do CPF está incorreto.");
        }
    }
}
