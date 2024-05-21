using FluentValidation;

namespace SUPERGASBRASIL_API.Mappers.Models.InputModel
{
    public class ClientNatural_InputModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string DateOfBirth { get; set; }
        public string CPF { get; set; }
    }
}
