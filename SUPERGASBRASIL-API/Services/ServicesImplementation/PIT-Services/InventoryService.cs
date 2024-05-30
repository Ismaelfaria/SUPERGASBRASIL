using SUPERGASBRASIL_API.Entities.PIT;
using SUPERGASBRASIL_API.Repositories.Interfaces.PIT_RepositoryInterfaces;
using SUPERGASBRASIL_API.Services.Interfaces.PIT_ServicesInterfaces;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.PIT_Services
{
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository _inv;

        public InventoryService(IInventoryRepository inv)
        {
            _inv = inv;
        }

        public Inventory CreateInventory(Inventory inventory)
        {
            _inv.CreateInventory(inventory);

            return inventory;
        }

        public void DeleteInventory(Guid id)
        {
            _inv.DeleteInventory(id);
        }

        public IEnumerable<Inventory> FindAll()
        {
            return _inv.FindAll();
        }

        public Inventory FindByIdInventory(Guid id)
        {
            return _inv.FindByIdInventory(id);
        }

        public void UpdateInventory(Guid id, int qtd)
        {
            _inv.UpdateInventory(id, qtd);
        }
    }
}
