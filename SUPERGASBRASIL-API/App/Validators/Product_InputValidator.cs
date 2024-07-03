using FluentValidation;
using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;

namespace SUPERGASBRASIL_API.App.Validators
{
    public class Product_InputValidator : AbstractValidator<Product_InputModel>
    {
        public Product_InputValidator()
        {
            RuleFor(a => a.name)
                .NotEmpty()
                .WithMessage("O nome do Produto não pode ser vazio");
            RuleFor(a => a.Description)
                .NotEmpty()
                .WithMessage("A descrição não pode ser vazia");
            RuleFor(a => a.Price)
                .NotEmpty()
                .WithMessage("O valor do produto é obrigatório");
        }
    }
}
