namespace SUPERGASBRASIL_API.Mappers.Models.ViewModel
{
    public class ClientNatural_ViewModel
    {
        public Guid IdClientNaturalPerson { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CPF { get; set; }
        public bool IsDeleted { get; set; }
    }
}
