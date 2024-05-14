using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces
{
    public interface ISalesRepository
    {
        void Create(Sales venda);
        void Delete(Guid id);
        IEnumerable<Sales> FindAll();
        Sales FindById(Guid id);
        Sales FindByDateSale(DateTime DateSale);
        void Sales(Guid id, GeneralReport venda);
    }
}
