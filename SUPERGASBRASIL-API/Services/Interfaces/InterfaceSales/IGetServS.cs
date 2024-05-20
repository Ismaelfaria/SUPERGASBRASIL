using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Services.Interfaces.InterfaceSales
{
    public interface IGetServS
    {
        IEnumerable<Sales> FindAll();
        Sales FindById(Guid id);
        Sales FindByDateSale(DateTime DateSale);
    }
}
