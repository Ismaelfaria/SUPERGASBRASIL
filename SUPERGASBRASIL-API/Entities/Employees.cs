using SUPERGASBRASIL_API.Entities.Enum;
using System.Text.Json.Serialization;

namespace SUPERGASBRASIL_API.Entities
{
    public class Employees
    {
        public Guid IdEmployees { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Cpf { get; set; }
        public DateTime DateOfBirth { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EPositions Position { get; set; }
        public string Positions { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsDeleted { get; set; }

        public Employees(string cpf, string name, int age, DateTime dateOfBirth, EPositions position, decimal salary, DateTime hireDate)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Age = age;
            Cpf = cpf;
            DateOfBirth = dateOfBirth;
            Position = position;
            Salary = salary;
            HireDate = hireDate;
            IsDeleted = false;
        }
        public void Deleted()
        {
            IsDeleted = true;
        }
        public void Update(string cpf, string name, int age, DateTime dateOfBirth, EPositions position, decimal salary, DateTime hireDate)
        {
            Cpf = cpf;
            Name = name;
            Age = age;
            DateOfBirth = dateOfBirth;
            Position = position;
            Salary = salary;
            HireDate = hireDate;
        }
    }
}
