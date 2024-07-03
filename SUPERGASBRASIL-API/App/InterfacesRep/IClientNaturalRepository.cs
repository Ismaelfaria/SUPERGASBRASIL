using SUPERGASBRASIL_API.Domain;

namespace SUPERGASBRASIL_API.App.Interfaces
{
    public interface IClientNaturalRepository
    {
        ClientNaturalPerson CreateClientNatural(ClientNaturalPerson clientNatural);
        void DeleteClientNatural(Guid id);
        IEnumerable<ClientNaturalPerson> FindAll();
        ClientNaturalPerson FindByCpf(string cpf);
        ClientNaturalPerson FindByName(string name);
        void UpdateClientNatural(string cpf, ClientNaturalPerson clientLegal);

    }
}
