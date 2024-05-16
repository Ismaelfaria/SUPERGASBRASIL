using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Services.Interfaces.InterfaceClientLegal
{
    public interface IUpdate
    {
        void UpdateClientLegal(int cnpj, ClientLegalEntity clientLegal);

    }
}
