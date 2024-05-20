using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceAdmin;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryAdmin
{
    public class CreateA : ICreateA
    {
        private readonly GasContext _context;
        public CreateA(GasContext context)
        {
            _context = context;
        }
        public Admin CreateAdmin(Admin admin)
        {
            _context.Admin.Add(admin);
            _context.SaveChanges();

            return admin;
        }
    }
}
