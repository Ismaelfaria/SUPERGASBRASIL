using FluentValidation;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;

namespace SUPERGASBRASIL_API.Validators
{
    public class User_InputValidator : AbstractValidator<User_InputModel>
    {

        public User_InputValidator()
        {
            RuleFor(a => a.Username)
                .NotEmpty()
                .WithMessage("O nome do usuario não pode ser vazio");
            RuleFor(a => a.Password)
                .NotEmpty()
                .WithMessage("A senha do usuario não pode ser vazia");
            RuleFor(a => a.Role)
                .NotEmpty()
                .WithMessage("A função do usuario não pode ser vazia");
        }
    }
}
