using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientNatural;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceClientNatural;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesClientNatural
{
    public class DeleteSCN : IDeleteServCN
    {
        private readonly IDeleteClientN DeleteCn;
        public DeleteSCN(IDeleteClientN deleteCn)
        {
            DeleteCn = deleteCn;
        }
        public void DeleteClientNatural(Guid id)
        {
            DeleteCn.DeleteClientNatural(id);
        }
    }
}
