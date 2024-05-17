using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientLegal;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceClientLegal;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesClientLegal
{
    public class Update : IUpdateServ
    {
        private readonly IUpdateClientL UpdateC;
        public Update(IUpdateClientL updateC)
        {
            UpdateC = updateC;
        }
        public void UpdateClientLegal(int cnpj, ClientLegalEntity clientLegal)
        {
            UpdateC.UpdateClientLegal(cnpj, clientLegal);
        }
    }
}
