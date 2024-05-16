using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceSales;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesSales
{
    public class Get : IGet
    {
        private readonly GasContext _context;
        public Get(GasContext context)
        {
            _context = context;
        }
        public IEnumerable<Sales> FindAll()
        {
            var usersDatabase = _context.Sales.Where(a => !a.IsDeleted).ToList();

            return usersDatabase;
        }

        public Sales FindByDateSale(DateTime timeOfSale)
        {
            var userDatabase = _context.Sales.SingleOrDefault(a => a.TimeOfSale == timeOfSale);

            if (userDatabase == null)
            {
                return null;
            }

            return userDatabase;
        }

        public Sales FindById(Guid id)
        {
            var userDatabase = _context.Sales.SingleOrDefault(a => a.IdSales == id);

            if (userDatabase == null)
            {
                return null;
            }

            return userDatabase;
        }
    }
}
