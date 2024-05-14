using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces
{
    public interface IClientLegalEntityRepository
    {
        void Create(ClientLegalEntity clientLegal);
        void Delete(Guid id);
        IEnumerable<ClientLegalEntity> FindAll();
        ClientLegalEntity FindByCnpj(int cnpj);
        ClientLegalEntity FindByCompanyName(string name);
        void Update(int cnpj, ClientLegalEntity clientLegal);
    }
}
