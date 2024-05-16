using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Services.Interfaces.InterfaceEmployees
{
    public interface IUpdateServ
    {
        void UpdateEmployee(int cpf, Employees funcionario);
    }
}
