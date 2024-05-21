using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces
{
    public interface IClientNaturalRepository
    {
        ClientNaturalPerson CreateClientNatural(ClientNaturalPerson clientNatural);
        void DeleteClientNatural(Guid id);
        IEnumerable<ClientNaturalPerson> FindAll();
        ClientNaturalPerson FindByCpf(int cpf);
        ClientNaturalPerson FindByName(string name);
        void UpdateClientNatural(int cpf, ClientNaturalPerson clientLegal);

    }
}
