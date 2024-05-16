using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceEmployees;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceEmployees;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesEmployee
{
    public class Get : IGetServ
    {
        private readonly IGet GetE;
        public Get(IGet getE)
        {
            GetE = getE;
        }
        public IEnumerable<Employees> FindAll()
        {
            var usersDatabase = GetE.FindAll();

            return usersDatabase;
        }

        public Employees FindByCpf(int cpf)
        {
            var usersDatabase = GetE.FindByCpf(cpf);

            return usersDatabase;
        }

        public Employees FindByName(string name)
        {
            var usersDatabase = GetE.FindByName(name);

            return usersDatabase;

        }
    }
}
