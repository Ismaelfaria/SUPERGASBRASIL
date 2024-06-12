using AutoMapper;
using FluentValidation;
using SUPERGASBRASIL_API.Entities.PIT;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;
using SUPERGASBRASIL_API.Repositories.Interfaces.PIT_RepositoryInterfaces;
using SUPERGASBRASIL_API.Services.Interfaces.PIT_ServicesInterfaces;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.PIT_Services
{
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository _inv;
        private readonly IProductRepository _invS;
        private readonly IMapper _map;
        private readonly IValidator<Inventory_InputModel> validator;

        public InventoryService(IInventoryRepository inv, IProductRepository invS, IMapper map, IValidator<Inventory_InputModel> validator)
        {
            _inv = inv;
            _invS = invS;
            _map = map;
            this.validator = validator;
        }

        public Inventory CreateInventory(Inventory_InputModel inventory)
        {
            var validResult = validator.Validate(inventory);

            if (!validResult.IsValid)
            {
                throw new ValidationException("Erro na validação ao criar o inventario");
            }

            var createMapObject = _map.Map<Inventory>(inventory);

            createMapObject.IdInventory = Guid.NewGuid();

            var obj = _invS.FindByIdProduct(createMapObject.IdProduct);

            createMapObject.Product = obj;

            _inv.CreateInventory(createMapObject);

            return createMapObject;
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
            var obj = _inv.FindByIdInventory(id);

            return obj;
        }

        public void UpdateInventory(Guid id, int qtd)
        {
            _inv.UpdateInventory(id, qtd);
        }
    }
}
