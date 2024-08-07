﻿using SUPERGASBRASIL_API.Domain.PIT;
using SUPERGASBRASIL_API.Infra.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.PIT_RepositoryInterfaces;

namespace SUPERGASBRASIL_API.Repositories.Repositorios
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly GasContext _context;

        public InventoryRepository(GasContext context)
        {
            _context = context;
        }

        public Inventory CreateInventory(Inventory inventory)
        {
            _context.Inventory.Add(inventory);
            _context.SaveChanges();

            return inventory;
        }
        public void DeleteInventory(Guid id)
        {
            var userDatabase = _context.Inventory.SingleOrDefault(a => a.IdInventory == id);

            userDatabase.Delete();
            _context.SaveChanges();
        }

        public IEnumerable<Inventory> FindAll()
        {
            var usersDatabase = _context.Inventory.Where(a => !a.IsDeleted).ToList();

            return usersDatabase;
        }

        public Inventory FindByIdInventory(Guid id)
        {
            var userDatabase = _context.Inventory.SingleOrDefault(a => a.IdInventory == id);

            if (userDatabase == null)
            {
                return null;
            }

            return userDatabase;
        }

        public void UpdateInventory(int qtd, Guid idInventory)
        {
            var userDatabase = _context.Inventory.SingleOrDefault(a => a.IdInventory == idInventory);

            userDatabase.UpdateInventory(qtd);

            _context.SaveChanges();
        }
    }
}
