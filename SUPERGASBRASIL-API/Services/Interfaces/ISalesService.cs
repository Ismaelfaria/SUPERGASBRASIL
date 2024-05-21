using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Services.Interfaces
{
    public interface ISalesService
    {
        Sales CreateSales(Sales venda);
        void DeleteSales(Guid id);
        IEnumerable<Sales> FindAll();
        Sales FindById(Guid id);
        Sales FindByDateSale(DateTime DateSale);
    }
}
