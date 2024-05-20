using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Services.Interfaces.InterfaceClientLegal
{
    public interface IUpdateServCL
    {
        void UpdateClientLegal(int cnpj, ClientLegalEntity clientLegal);

    }
}
