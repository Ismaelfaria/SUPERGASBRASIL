using SUPERGASBRASIL_API.Domain;

namespace SUPERGASBRASIL_API.App.Interfaces
{
    public interface IClientLegalRepository
    {
        ClientLegalEntity CreateClientLegal(ClientLegalEntity clientLegal);
        void DeleteClientLegal(Guid id);
        IEnumerable<ClientLegalEntity> FindAll();
        ClientLegalEntity FindByCnpj(long cnpj);
        ClientLegalEntity FindByCompanyName(string name);
        void UpdateClientLegal(long cnpj, ClientLegalEntity clientLegal);

    }
}
