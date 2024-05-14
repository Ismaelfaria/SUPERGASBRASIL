using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceSales
{
    public interface IUpdate
    {
        void Sales(Guid id, GeneralReport venda);
    }
}
