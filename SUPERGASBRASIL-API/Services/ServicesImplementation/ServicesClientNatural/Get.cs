using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientNatural;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceClientNatural;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesClientNatural
{
    public class Get : IGetServ
    {
        private readonly IGet GetCn;
        public Get(IGet getCn)
        {
            GetCn = getCn;
        }
        public IEnumerable<ClientNaturalPerson> FindAll()
        {
            var usersDatabase = GetCn.FindAll();

            return usersDatabase;
        }

        public ClientNaturalPerson FindByCpf(int cpf)
        {
            var usersDatabase = GetCn.FindByCpf(cpf);

            return usersDatabase;
        }

        public ClientNaturalPerson FindByName(string name)
        {
            var usersDatabase = GetCn.FindByName(name);

            return usersDatabase;
        }
    }
}
