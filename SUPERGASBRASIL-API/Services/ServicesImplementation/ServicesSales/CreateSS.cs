using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceSales;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceSales;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesSales
{
    public class CreateSS : ICreateServS
    {
        private readonly ICreateS CreateS;
        public CreateSS(ICreateS createS)
        {
            CreateS = createS;
        }
        public Sales CreateSales(Sales venda)
        {
            CreateS.CreateSales(venda);

            return venda;
        }
    }
}
