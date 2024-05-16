using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceSales;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceSales;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesSales
{
    public class Create : ICreateServ
    {
        private readonly ICreate CreateS;
        public Create(ICreate createS)
        {
            CreateS = createS;
        }
        public void CreateSales(Sales venda)
        {
            CreateS.CreateSales(venda);
        }
    }
}
