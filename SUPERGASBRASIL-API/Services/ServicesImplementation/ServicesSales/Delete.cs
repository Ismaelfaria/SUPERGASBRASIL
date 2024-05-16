using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceSales;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesSales
{
    public class Delete : IDelete
    {
        private readonly GasContext _context;
        public Delete(GasContext context)
        {
            _context = context;
        }
        public void DeleteSales(Guid id)
        {
            var userDatabase = _context.Sales.SingleOrDefault(a => a.IdSales == id);

            userDatabase.Deleted();
            _context.SaveChanges();
        }
    }
}
