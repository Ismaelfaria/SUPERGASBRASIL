using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces
{
    public interface ISalesRepository
    {
        Sales CreateSales(Sales venda);
        void DeleteSales(Guid id);
        IEnumerable<Sales> FindAll();
        Sales FindById(Guid id);
        Sales FindByDateSale(DateTime DateSale);
    }
}
