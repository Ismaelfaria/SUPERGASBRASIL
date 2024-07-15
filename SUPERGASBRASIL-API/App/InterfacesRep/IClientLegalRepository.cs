using SUPERGASBRASIL_API.App.InterfacesRep;
using SUPERGASBRASIL_API.Domain;

namespace SUPERGASBRASIL_API.App.Interfaces
{
    public interface IClientLegalRepository : IRepository<ClientLegalEntity>
    {
        ClientLegalEntity FindByCnpj(long cnpj);
        ClientLegalEntity FindByCompanyName(string name);
        void UpdateClientLegal(long cnpj, ClientLegalEntity clientLegal);

    }
}
