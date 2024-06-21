using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryAdmin
{
    public class AdminRepository : IAdminRepository
    {
        private readonly GasContext _context;

        public AdminRepository(GasContext context)
        {
            _context = context;
        }

        public Admin CreateAdmin(Admin admin)
        {
            _context.Admin.Add(admin);
            _context.SaveChanges();

            return admin;
        }
        public void DeleteAdmin(Guid id)
        {
            var userDatabase = _context.Admin.SingleOrDefault(a => a.IdAdmin == id);

            userDatabase.Deleted();
            _context.SaveChanges();
        }

        public IEnumerable<Admin> FindAll()
        {
            var usersDatabase = _context.Admin.Where(a => !a.IsDeleted).ToList();

            return usersDatabase;
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
