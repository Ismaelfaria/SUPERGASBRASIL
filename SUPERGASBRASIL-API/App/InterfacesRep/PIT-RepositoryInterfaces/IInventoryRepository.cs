﻿using SUPERGASBRASIL_API.Domain.PIT;

namespace SUPERGASBRASIL_API.Repositories.Interfaces.PIT_RepositoryInterfaces
{
    public interface IInventoryRepository
    {
        Inventory CreateInventory(Inventory inventory);
        void DeleteInventory(Guid id);
        IEnumerable<Inventory> FindAll();
        Inventory FindByIdInventory(Guid id);
        void UpdateInventory(int qtd, Guid IdInventory);
    }
}
