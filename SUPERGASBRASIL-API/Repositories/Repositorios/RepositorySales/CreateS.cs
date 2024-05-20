using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceSales;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositorySales
{
    public class CreateS : ICreateS
    {
        private readonly GasContext _context;
        public CreateS(GasContext context)
        {
            _context = context;
        }
        public Sales CreateSales(Sales venda)
        {
            _context.Sales.Add(venda);
            _context.SaveChanges();

            return venda;
        }
    }
}
