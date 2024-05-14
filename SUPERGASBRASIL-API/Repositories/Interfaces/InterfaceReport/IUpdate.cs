using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceReport
{
    public interface IUpdate
    {
        void Update(Guid id, GeneralReport relatorio);
    }
}
