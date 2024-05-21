using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces
{
    public interface IClientLegalRepository
    {
        ClientLegalEntity CreateClientLegal(ClientLegalEntity clientLegal);
        void DeleteClientLegal(Guid id);
        IEnumerable<ClientLegalEntity> FindAll();
        ClientLegalEntity FindByCnpj(string cnpj);
        ClientLegalEntity FindByCompanyName(string name);
        void UpdateClientLegal(string cnpj, ClientLegalEntity clientLegal);

    }
}
