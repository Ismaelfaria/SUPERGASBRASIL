namespace SUPERGASBRASIL_API.Entities
{
    public class ClientNaturalPerson
    {
        public Guid IdClientNaturalPerson { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CPF { get; set; }
        public bool IsDeleted { get; set; }

        public void Update(string name, int age, DateTime dateOfBirth, string cpf)
        {
            Name = name;
            Age = age;
            DateOfBirth = dateOfBirth;
            CPF = cpf;
        }
        public void Deleted()
        {
            IsDeleted = true;
        }
    }
}
