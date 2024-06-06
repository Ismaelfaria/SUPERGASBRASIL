using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;

namespace SUPERGASBRASIL_API.Services.Interfaces
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
