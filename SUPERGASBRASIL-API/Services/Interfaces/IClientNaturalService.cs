using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Services.Interfaces
{
    public interface IClientNaturalService
    {
        ClientNaturalPerson CreateClientNatural(ClientNaturalPerson clientNatural);
        void DeleteClientNatural(Guid id);
        IEnumerable<ClientNaturalPerson> FindAll();
        ClientNaturalPerson FindByCpf(string cpf);
        ClientNaturalPerson FindByName(string name);
        void UpdateClientNatural(string cpf, ClientNaturalPerson clientLegal);

    }
}
