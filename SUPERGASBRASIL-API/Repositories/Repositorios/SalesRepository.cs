using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositorySales
{
    public class SalesRepository : ISalesRepository
    {
        private readonly GasContext _context;

        public SalesRepository(GasContext context)
        {
            _context = context;
        }

        public Sales CreateSales(Sales venda)
        {
            _context.Sales.Add(venda);
            _context.SaveChanges();

            return venda;
        }
        public void DeleteSales(Guid id)
        {
            var userDatabase = _context.Sales.SingleOrDefault(a => a.IdSales == id);

            userDatabase.Deleted();
            _context.SaveChanges();
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
