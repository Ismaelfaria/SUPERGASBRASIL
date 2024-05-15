using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientNatural;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryClientNatural
{
    public class Delete : IDelete
    {
        private readonly GasContext _context;
        public Delete(GasContext context)
        {
            _context = context;
        }
        public void DeleteClientNatural(Guid id)
        {
            var userDatabase = _context.ClientNatural.SingleOrDefault(a => a.IdClientNaturalPerson == id);

            userDatabase.Deleted();
            _context.SaveChanges();
        }
    }
}
