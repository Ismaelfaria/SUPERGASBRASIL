using SUPERGASBRASIL_API.Entities.Enum;
using SUPERGASBRASIL_API.Entities.PIT;

namespace SUPERGASBRASIL_API.Services.Interfaces.PIT_ServicesInterfaces
{
    public interface ITransactionService
    {
        void ProcessTransaction(Guid productId, ETransactionINorOUT type, int quantity);
        IEnumerable<Transaction> FindAll();
    }
}
