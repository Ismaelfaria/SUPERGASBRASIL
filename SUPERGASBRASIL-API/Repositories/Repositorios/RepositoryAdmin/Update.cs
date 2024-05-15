using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryAdmin
{
    public class Update
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
