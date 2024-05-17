using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientNatural;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceClientNatural;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesClientNatural
{
    public class Update : IUpdateServ
    {
        private readonly IUpdateClientN UpdateCn;
        public Update(IUpdateClientN updateCn)
        {
            UpdateCn = updateCn;
        }
        public void UpdateClientNatural(int cpf, ClientNaturalPerson clientNatural)
        {
            UpdateCn.UpdateClientNatural(cpf, clientNatural);
        }
    }
}
