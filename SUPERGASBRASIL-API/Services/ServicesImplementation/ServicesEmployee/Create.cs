using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceEmployees;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceEmployees;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesEmployee
{
    public class Create : ICreateServ
    {
        private readonly ICreateE CreateE;
        public Create(ICreateE createE)
        {
            CreateE = createE;
        }
        public void CreateEmployee(Employees employee)
        {
            CreateE.CreateEmployee(employee);
        }
    }
}
