namespace SUPERGASBRASIL_API.Entities
{
    public class Employees
    {
        public Guid IdEmployees { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Cpf { get; set; }
        public DateTime DateOfBirth { get; set; }
        //Menu De Seleção para informar qual vai ser o tipo de cargo
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsDeleted { get; set; }

        public Employees(int cpf, string name, int age, DateTime dateOfBirth, string position, decimal salary, DateTime hireDate)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Age = age;
            Cpf = cpf;
            DateOfBirth = dateOfBirth;
            Position = position ?? throw new ArgumentNullException(nameof(position));
            Salary = salary;
            HireDate = hireDate;
            IsDeleted = false;
        }
        public void Deleted()
        {
            IsDeleted = true;
        }
        public void Update(int cpf, string name, int age, DateTime dateOfBirth, string position, decimal salary, DateTime hireDate)
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
