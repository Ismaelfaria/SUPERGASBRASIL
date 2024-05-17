using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceSales;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceSales;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesSales
{
    public class Delete : IDeleteServ
    {
        private readonly IDeleteS DeleteS;
        public Delete(IDeleteS deleteS)
        {
            DeleteS = deleteS;
        }
        public void DeleteSales(Guid id)
        {
            DeleteS.DeleteSales(id);
        }
    }
}
