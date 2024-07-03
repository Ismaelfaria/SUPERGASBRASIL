using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.Domain.PIT;

namespace SUPERGASBRASIL_API.Services.Interfaces.PIT_ServicesInterfaces
{
    public interface IInventoryService
    {
        Inventory CreateInventory(Inventory_InputModel inventory);
        void DeleteInventory(Guid id);
        IEnumerable<Inventory> FindAll();
        Inventory FindByIdInventory(Guid id);
        void UpdateInventory(int qtd, Guid IdInventory);
    }
}
