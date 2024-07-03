using SUPERGASBRASIL_API.Domain.Enum;

namespace SUPERGASBRASIL_API.App.Mapping.Models.InputModel
{
    public class Employees_InputModel
    {
        public string Name { get; set; }
        public long Cpf { get; set; }
        public DateTime DateOfBirth { get; set; }
        public EPositions Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
    }
}
