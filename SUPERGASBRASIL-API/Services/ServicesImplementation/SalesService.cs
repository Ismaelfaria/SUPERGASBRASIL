using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Repositories.Interfaces;
using SUPERGASBRASIL_API.Services.Interfaces;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation
{
    public class SalesService : ISalesService
    {
        private readonly ISalesRepository Sales;

        public SalesService(ISalesRepository sales)
        {
            Sales = sales;
        }

        public Sales CreateSales(Sales venda)
        {
            Sales.CreateSales(venda);

            return venda;
        }
        public void DeleteSales(Guid id)
        {
            Sales.DeleteSales(id);
        }
        public IEnumerable<Sales> FindAll()
        {
            var usersDatabase = Sales.FindAll();

            return usersDatabase;
        }

        public Sales FindByDateSale(DateTime timeOfSale)
        {
            var usersDatabase = Sales.FindByDateSale(timeOfSale);

            return usersDatabase;
        }

        public Sales FindById(Guid id)
        {
            var usersDatabase = Sales.FindById(id);

            return usersDatabase;
        }
    }
}
