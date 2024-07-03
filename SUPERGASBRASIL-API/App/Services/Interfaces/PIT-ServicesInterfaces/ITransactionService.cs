using SUPERGASBRASIL_API.Domain.Enum;
using SUPERGASBRASIL_API.Domain.PIT;

namespace SUPERGASBRASIL_API.Services.Interfaces.PIT_ServicesInterfaces
{
    public interface ITransactionService
    {
        void ProcessTransaction(Guid productId, ETransactionINorOUT type, int quantity);
        IEnumerable<Transaction> FindAll();
    }
}
