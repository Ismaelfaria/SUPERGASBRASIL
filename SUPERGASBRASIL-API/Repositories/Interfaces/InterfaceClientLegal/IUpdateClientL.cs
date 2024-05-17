using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientLegal
{
    public interface IUpdateClientL
    {
        void UpdateClientLegal(int cnpj, ClientLegalEntity clientLegal);

    }
}
