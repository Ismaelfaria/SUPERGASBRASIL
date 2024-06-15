using SUPERGASBRASIL_API.Entities.Enum;
using SUPERGASBRASIL_API.Entities.PIT;
using SUPERGASBRASIL_API.Persistence.Context;
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

        public void ProcessTransaction(Guid productId, ETransactionINorOUT type, int quantity)
        {
            var product = _productRepository.FindByIdProduct(productId);

            if (product == null)
            {
                throw new Exception("Product not found");
            }

            var inventory = _inventoryRepository.FindByIdInventory(productId);

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
                IdProduct = productId,
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
            // _inventoryRepository.UpdateInventory(inventory.IdInventory, inventory.Quantity);

            _context.SaveChanges();
        }
    }
}
