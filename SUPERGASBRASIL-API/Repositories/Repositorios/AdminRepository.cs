using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces;

namespace SUPERGASBRASIL_API.Repositories.Repositorios
{
    public class AdminRepository : IAdminRepository
    {
        private readonly GasContext _context;
        public AdminRepository(GasContext context)
        {
            _context = context;
        }
        public void Create(Admin client)
        {
            _context.Admin.Add(client);
            _context.SaveChanges();
        }
        public void Delete(Guid id)
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
        public void Update(string userName, Admin admin)
        {
            var userDatabase = _context.Admin.SingleOrDefault(a => a.Username == userName);

            userDatabase.Update(admin.Username, admin.Password);
            _context.SaveChanges();
        }
    }
}
