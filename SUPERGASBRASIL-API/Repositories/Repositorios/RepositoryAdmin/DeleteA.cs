using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceAdmin;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryAdmin
{
    public class DeleteA : IDeleteA
    {
        private readonly GasContext _context;
        public DeleteA(GasContext context)
        {
            _context = context;
        }
        public void DeleteAdmin(Guid id)
        {
            var userDatabase = _context.Admin.SingleOrDefault(a => a.IdAdmin == id);

            userDatabase.Deleted();
            _context.SaveChanges();
        }
    }
}
