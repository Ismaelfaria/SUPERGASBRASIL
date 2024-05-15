using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientLegal;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryClientLegal
{
    public class Delete : IDelete
    {
        private readonly GasContext _context;
        public Delete(GasContext context)
        {
            _context = context;
        }
        public void DeleteClientLegal(Guid id)
        {
            var userDatabase = _context.ClientLegal.SingleOrDefault(a => a.IdClientLegalEntity == id);

            userDatabase.Deleted();
            _context.SaveChanges();
        }
    }
}
