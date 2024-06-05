using FluentValidation;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;

namespace SUPERGASBRASIL_API.Validators
{
    public class ClientLegal_InputValidator : AbstractValidator<ClientLegal_InputModel>
    {
        public ClientLegal_InputValidator()
        {
            RuleFor(a => a.CompanyName)
                .NotEmpty()
                .WithMessage("O nome da empresa não pode ser vazio");

            RuleFor(a => a.ContactInformation)
                .NotEmpty()
                .WithMessage("O número de telefone deve estar no formato (XX) XXXX-XXXX ou (XX) XXXXX-XXXX.");
            
            RuleFor(a => a.TaxIdentificationNumberCNPJ)
                .NotEmpty()
                .Matches(@"^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$")
                .WithMessage("O formato do CNPJ está incorreto.");

            RuleFor(a => a.BusinessAddress)
                .NotEmpty()
                .WithMessage("O nome da empresa não pode ser vazio");

        }
    }
}
