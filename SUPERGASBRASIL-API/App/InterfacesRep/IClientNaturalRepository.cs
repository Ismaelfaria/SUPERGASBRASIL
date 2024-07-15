using SUPERGASBRASIL_API.App.InterfacesRep;
using SUPERGASBRASIL_API.Domain;

namespace SUPERGASBRASIL_API.App.Interfaces
{
    public interface IClientNaturalRepository : IRepository<ClientNaturalPerson>
    {
        ClientNaturalPerson FindByCpf(string cpf);
        ClientNaturalPerson FindByName(string name);
        void UpdateClientNatural(string cpf, ClientNaturalPerson clientLegal);

    }
}
