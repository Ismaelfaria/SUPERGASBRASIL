using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Services.Interfaces
{
    public interface IClientLegalService
    {
        ClientLegalEntity CreateClientLegal(ClientLegalEntity clientLegal);
        void DeleteClientLegal(Guid id);
        IEnumerable<ClientLegalEntity> FindAll();
        ClientLegalEntity FindByCnpj(int cnpj);
        ClientLegalEntity FindByCompanyName(string name);
        void UpdateClientLegal(int cnpj, ClientLegalEntity clientLegal);

    }
}
