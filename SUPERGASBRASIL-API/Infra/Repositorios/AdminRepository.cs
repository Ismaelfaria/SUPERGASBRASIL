using SUPERGASBRASIL_API.App.Interfaces;
using SUPERGASBRASIL_API.Domain;
using SUPERGASBRASIL_API.Infra.Context;

namespace SUPERGASBRASIL_API.Infra.Repositorios
{
    public class AdminRepository : RepositoryBase<Admin>
    {
        public AdminRepository(GasContext context) : base(context)
        {
        }
        public Admin FindByUserName(string name)
        {
            var userDatabase = _context.Admin.SingleOrDefault(a => a.Username == name);

            if (userDatabase == null)
            {
                return null;
            }

            return userDatabase;
        }
        public void UpdateAdmin(string userName, Admin admin)
        {
            var userDatabase = _context.Admin.SingleOrDefault(a => a.Username == userName);

            userDatabase.Update(admin.Username, admin.Password);
            _context.SaveChanges();
        }
    }
}
