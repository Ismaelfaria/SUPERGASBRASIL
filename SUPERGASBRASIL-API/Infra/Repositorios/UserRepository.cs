using SUPERGASBRASIL_API.App.Interfaces;
using SUPERGASBRASIL_API.Domain;
using SUPERGASBRASIL_API.Infra.Context;

namespace SUPERGASBRASIL_API.Infra.Repositorios
{
    public class UserRepository : RepositoryBase<Admin>
    {
        public UserRepository(GasContext context) : base(context)
        {
        }
        public IEnumerable<User> FindAll()
        {
            var usersDatabase = _context.User.Where(a => !a.IsDeleted).ToList();

            return usersDatabase;
        }

        public User FindByUserName(string name)
        {
            var userDatabase = _context.User.SingleOrDefault(a => a.Username == name);

            if (userDatabase == null)
            {
                return null;
            }

            return userDatabase;
        }
    }
}
