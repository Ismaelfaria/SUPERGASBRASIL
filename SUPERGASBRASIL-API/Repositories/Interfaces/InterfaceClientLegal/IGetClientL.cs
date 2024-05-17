using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientLegal
{
    public interface IGetClientL
    {
        IEnumerable<ClientLegalEntity> FindAll();
        ClientLegalEntity FindByCnpj(int cnpj);
        ClientLegalEntity FindByCompanyName(string name);

    }
}
