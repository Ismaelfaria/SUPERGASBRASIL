using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientNatural;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceClientNatural;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesClientNatural
{
    public class CreateSCN : ICreateServCN
    {
        private readonly ICreateClientN CreateCn;
        public CreateSCN(ICreateClientN createCn)
        {
            CreateCn = createCn;
        }
        public ClientNaturalPerson CreateClientNatural(ClientNaturalPerson clientNatural)
        {
            CreateCn.CreateClientNatural(clientNatural);

            return clientNatural;
        }

    }
}
