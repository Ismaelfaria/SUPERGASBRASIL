using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;

namespace SUPERGASBRASIL_API.Services.Interfaces
{
    public interface IClientNaturalService
    {
        ClientNaturalPerson CreateClientNatural(ClientNatural_InputModel clientNatural);
        void DeleteClientNatural(Guid id);
        IEnumerable<ClientNaturalPerson> FindAll();
        ClientNaturalPerson FindByCpf(string cpf);
        ClientNaturalPerson FindByName(string name);
        void UpdateClientNatural(string cpf, ClientNatural_InputModel clientLegal);

    }
}
