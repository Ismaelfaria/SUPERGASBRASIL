using SUPERGASBRASIL_API.Entities.PIT;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;

namespace SUPERGASBRASIL_API.Services.Interfaces.PIT_ServicesInterfaces
{
    public interface IInventoryService
    {
        Inventory CreateInventory(Inventory_InputModel inventory);
        void DeleteInventory(Guid id);
        IEnumerable<Inventory> FindAll();
        Inventory FindByIdInventory(Guid id);
        void UpdateInventory(Guid id, int qtd);
    }
}
