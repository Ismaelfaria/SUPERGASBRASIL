using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientNatural;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceClientNatural;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesClientNatural
{
    public class Create : ICreateServ
    {
        private readonly ICreateClientN CreateCn;
        public Create(ICreateClientN createCn)
        {
            CreateCn = createCn;
        }
        public void CreateClientNatural(ClientNaturalPerson clientNatural)
        {
            CreateCn.CreateClientNatural(clientNatural);
        }

    }
}
