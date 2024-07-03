using FluentValidation;
using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;

namespace SUPERGASBRASIL_API.App.Validators
{
    public class Inventory_InputValidator : AbstractValidator<Inventory_InputModel>
    {
        public Inventory_InputValidator()
        {
            RuleFor(a => a.IdProduct)
                .NotEmpty()
                .WithMessage("O Id do produto não pode ser vazio");
            RuleFor(a => a.Quantity)
                .NotEmpty()
                .WithMessage("A qtd não pode ser vazia");
        }
    }
}
