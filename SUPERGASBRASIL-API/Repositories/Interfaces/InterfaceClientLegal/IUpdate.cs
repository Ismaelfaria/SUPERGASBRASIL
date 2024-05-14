using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientLegal
{
    public interface IUpdate
    {
        void Update(int cnpj, ClientLegalEntity clientLegal);

    }
}
