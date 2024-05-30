using SUPERGASBRASIL_API.Entities.PIT;

namespace SUPERGASBRASIL_API.Repositories.Interfaces.PIT_RepositoryInterfaces
{
    public interface ITransactionRepository
    {
        Transaction CreateTransaction(Transaction transaction);
        void DeleteTransaction(Guid id);
        IEnumerable<Transaction> FindAll();
        Transaction FindByIdTransaction(Guid id);
    }
}
