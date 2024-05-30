using SUPERGASBRASIL_API.Entities.PIT;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.PIT_RepositoryInterfaces;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.PIT_Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly GasContext _context;

        public TransactionRepository(GasContext context)
        {
            _context = context;
        }

        public Transaction CreateTransaction(Transaction transaction)
        {
            _context.Transaction.Add(transaction);

            _context.SaveChanges();

            return transaction;
        }
        public void DeleteTransaction(Guid id)
        {
            var userDatabase = _context.Transaction.SingleOrDefault(a => a.IdTransaction == id);

            userDatabase.Delete();
            _context.SaveChanges();
        }

        public IEnumerable<Transaction> FindAll()
        {
            var usersDatabase = _context.Transaction.Where(a => !a.IsDeleted).ToList();

            return usersDatabase;
        }

        public Transaction FindByIdTransaction(Guid id)
        {
            var userDatabase = _context.Transaction.SingleOrDefault(a => a.IdTransaction == id);

            if (userDatabase == null)
            {
                return null;
            }

            return userDatabase;
        }
    }
}
