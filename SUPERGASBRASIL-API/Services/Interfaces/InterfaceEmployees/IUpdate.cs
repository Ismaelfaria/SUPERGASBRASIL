using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Services.Interfaces.InterfaceEmployees
{
    public interface IUpdate
    {
        void UpdateEmployee(int cpf, Employees funcionario);
    }
}
