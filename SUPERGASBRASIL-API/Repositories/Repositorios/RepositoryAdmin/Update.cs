using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceAdmin;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryAdmin
{
    public class Update : IUpdate
    {
        private readonly GasContext _context;
        public Update(GasContext context)
        {
            _context = context;
        }
        public void UpdateAdmin(string userName, Admin admin)
        {
            var userDatabase = _context.Admin.SingleOrDefault(a => a.Username == userName);

            userDatabase.Update(admin.Username, admin.Password);
            _context.SaveChanges();
        }
    }
}
