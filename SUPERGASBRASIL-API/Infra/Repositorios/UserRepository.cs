using SUPERGASBRASIL_API.App.Interfaces;
using SUPERGASBRASIL_API.Domain;
using SUPERGASBRASIL_API.Infra.Context;

namespace SUPERGASBRASIL_API.Infra.Repositorios
{
    public class UserRepository : IUserRepository
    {
        private readonly GasContext _context;

        public UserRepository(GasContext context)
        {
            _context = context;
        }

        public User Create(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();

            return user;
        }

        public void Delete(Guid id)
        {
            var userDatabase = _context.User.SingleOrDefault(a => a.Id == id);

            userDatabase.Deletar();
            _context.SaveChanges();
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
