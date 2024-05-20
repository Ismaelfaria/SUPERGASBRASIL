using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientLegal;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceClientLegal;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesClientLegal
{
    public class CreateSCL : ICreateServCL
    {
        private readonly ICreateClientL CreateC;
        public CreateSCL(ICreateClientL createC)
        {
            CreateC = createC;
        }
        public ClientLegalEntity CreateClientLegal(ClientLegalEntity clientLegal)
        {
            CreateC.CreateClientLegal(clientLegal);

            return clientLegal;
        }
    }
}
