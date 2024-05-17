using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientLegal;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryClientLegal
{
    public class DeleteClientL : IDeleteClientL
    {
        private readonly GasContext _context;
        public DeleteClientL(GasContext context)
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
