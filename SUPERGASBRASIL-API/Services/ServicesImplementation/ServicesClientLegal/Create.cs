using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientLegal;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceClientLegal;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesClientLegal
{
    public class Create : ICreateServ
    {
        private readonly ICreate CreateC;
        public Create(ICreate createC)
        {
            CreateC = createC;
        }
        public void CreateClientLegal(ClientLegalEntity clientLegal)
        {
            CreateC.CreateClientLegal(clientLegal);
        }
    }
}
