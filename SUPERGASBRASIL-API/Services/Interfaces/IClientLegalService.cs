using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;

namespace SUPERGASBRASIL_API.Services.Interfaces
{
    public interface IClientLegalService
    {
        void CreateClientLegal(ClientLegal_InputModel clientLegal);
        void DeleteClientLegal(Guid id);
        IEnumerable<ClientLegalEntity> FindAll();
        ClientLegalEntity FindByCnpj(string cnpj);
        ClientLegalEntity FindByCompanyName(string name);
        void UpdateClientLegal(string cnpj, ClientLegal_InputModel clientLegal);

    }
}
