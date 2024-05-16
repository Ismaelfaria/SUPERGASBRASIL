using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceAdmin;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesAdmin
{
    public class Delete : IDelete
    {
        private readonly GasContext _context;
        public Delete(GasContext context)
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
