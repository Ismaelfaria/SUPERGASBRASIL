namespace SUPERGASBRASIL_API.Entities
{
    public class ClientNaturalPerson
    {
        public Guid IdClientNaturalPerson { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string DateOfBirth { get; set; }
        public string CPF { get; set; }
        public bool IsDeleted { get; set; }

        public ClientNaturalPerson(string name, int age, string dateOfBirth, string cpf)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Age = age;
            DateOfBirth = dateOfBirth;
            CPF = cpf;
            IsDeleted = false;
        }
        public void Update(string name, int age, string dateOfBirth, string cpf)
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
