using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.Domain;

namespace SUPERGASBRASIL_API.App.Services.Interfaces
{
    public interface IClientLegalService
    {
        ClientLegalEntity CreateClientLegal(ClientLegal_InputModel clientLegal);
        void DeleteClientLegal(Guid id);
        IEnumerable<ClientLegalEntity> FindAll();
        ClientLegalEntity FindByCnpj(long cnpj);
        ClientLegalEntity FindByCompanyName(string name);
        void UpdateClientLegal(long cnpj, ClientLegal_InputModel clientLegal);

    }
}
