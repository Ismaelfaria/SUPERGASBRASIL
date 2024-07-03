using SUPERGASBRASIL_API.Domain.Enum;
using System.Text.Json.Serialization;

namespace SUPERGASBRASIL_API.Domain
{
    public class Employees
    {
        public Employees()
        {
            IsDeleted = false;
        }
        public Guid IdEmployees { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public long Cpf { get; set; }
        public DateTime DateOfBirth { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EPositions Position { get; set; }
        public string Positions { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsDeleted { get; set; }

        public void Deleted()
        {
            IsDeleted = true;
        }
        public void Update(long cpf, string name, int age, DateTime dateOfBirth, EPositions position, decimal salary, DateTime hireDate)
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
