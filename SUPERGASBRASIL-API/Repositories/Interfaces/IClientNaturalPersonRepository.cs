using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces
{
    public interface IClientNaturalPersonRepository
    {
        void Create(ClientNaturalPerson clientNatural);
        void Delete(Guid id);
        IEnumerable<ClientNaturalPerson> FindAll();
        ClientNaturalPerson FindByCpf(int cpf);
        ClientNaturalPerson FindByName(string name);
        void Update(int cpf, ClientNaturalPerson clientLegal);
    }
}
