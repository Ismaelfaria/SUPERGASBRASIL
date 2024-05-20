using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientNatural;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceClientNatural;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesClientNatural
{
    public class GetSCN : IGetServCN
    {
        private readonly IGetClientN GetCn;
        public GetSCN(IGetClientN getCn)
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
