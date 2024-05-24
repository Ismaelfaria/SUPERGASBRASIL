using FluentValidation;

namespace SUPERGASBRASIL_API.Mappers.Models.InputModel
{
    public class ClientNatural_InputModel
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CPF { get; set; }
    }
}
