using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Services.Interfaces.InterfaceClientLegal
{
    public interface IGet
    {
        IEnumerable<ClientLegalEntity> FindAll();
        ClientLegalEntity FindByCnpj(int cnpj);
        ClientLegalEntity FindByCompanyName(string name);

    }
}
