using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceEmployees;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceEmployees;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesEmployee
{
    public class CreateSE : ICreateServE
    {
        private readonly ICreateE CreateE;
        public CreateSE(ICreateE createE)
        {
            CreateE = createE;
        }
        public Employees CreateEmployee(Employees employee)
        {
            CreateE.CreateEmployee(employee);

            return employee;
        }
    }
}
