using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.Domain;

namespace SUPERGASBRASIL_API.App.Services.Interfaces
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
