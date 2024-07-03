using SUPERGASBRASIL_API.Domain.Enum;
using SUPERGASBRASIL_API.Domain.PIT;
using SUPERGASBRASIL_API.Infra.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.PIT_RepositoryInterfaces;
using SUPERGASBRASIL_API.Services.Interfaces.PIT_ServicesInterfaces;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.PIT_Services
{
    public class TransactionService : ITransactionService
    {
        private readonly GasContext _context;
        private readonly ITransactionRepository _transactionRepository;
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IProductRepository _productRepository;

        public TransactionService(
            GasContext context,
            ITransactionRepository transactionRepository,
            IInventoryRepository inventoryRepository,
            IProductRepository productRepository)
        {
            _context = context;
            _transactionRepository = transactionRepository;
            _inventoryRepository = inventoryRepository;
            _productRepository = productRepository;
        }

        public IEnumerable<Transaction> FindAll()
        {
            return _transactionRepository.FindAll();
        }

        public void ProcessTransaction(Guid inventoryId, ETransactionINorOUT type, int quantity)
        {

            var inventory = _inventoryRepository.FindByIdInventory(inventoryId);

            if (inventory == null)
            {
                throw new Exception("Inventory record not found for product");
            }

            if (type == ETransactionINorOUT.OUT && inventory.Quantity < quantity)
            {
                throw new Exception("Insufficient stock for the transaction");
            }

            var transaction = new Transaction
            {
                IdInventary = inventoryId,
                Type = type,
                Quantity = quantity,
                CreatedAt = DateTime.UtcNow
            };

            if (type == ETransactionINorOUT.IN)
            {
                inventory.Quantity += quantity;
            }
            else if (type == ETransactionINorOUT.OUT)
            {
                inventory.Quantity -= quantity;
            }

            _transactionRepository.CreateTransaction(transaction);
            _inventoryRepository.UpdateInventory(inventory.Quantity, inventory.IdInventory);

            _context.SaveChanges();
        }
    }
}
