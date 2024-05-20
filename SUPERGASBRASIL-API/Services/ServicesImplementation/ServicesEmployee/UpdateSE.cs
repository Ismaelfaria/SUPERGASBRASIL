using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceEmployees;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceEmployees;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesEmployee
{
    public class UpdateSE : IUpdateServE
    {
        private readonly IUpdateE UpdateE;
        public UpdateSE(IUpdateE updateE)
        {
            UpdateE = updateE;
        }
        public void UpdateEmployee(int cpf, Employees employee)
        {
            UpdateE.UpdateEmployee(cpf, employee);
        }
    }
}
