namespace SUPERGASBRASIL_API.Mappers.Models.ViewModel
{
    public class Employees_ViewModel
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
    }
}
