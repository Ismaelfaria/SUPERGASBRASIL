using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientLegal;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceClientLegal;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesClientLegal
{
    public class GetSCL : IGetServCL
    {
        private readonly IGetClientL GetC;
        public GetSCL(IGetClientL getC)
        {
            GetC = getC;
        }
        public IEnumerable<ClientLegalEntity> FindAll()
        {
            var usersDatabase = GetC.FindAll();

            return usersDatabase;
        }

        public ClientLegalEntity FindByCnpj(int cnpj)
        {
            var usersDatabase = GetC.FindByCnpj(cnpj);

            return usersDatabase;
        }

        public ClientLegalEntity FindByCompanyName(string name)
        {
            var usersDatabase = GetC.FindByCompanyName(name);

            return usersDatabase;
        }

    }
}
