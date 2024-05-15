using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryAdmin
{
    public class Create
    {
        private readonly GasContext _context;
        public Create(GasContext context)
        {
            _context = context;
        }
        public void CreateAdmin(Admin client)
        {
            _context.Admin.Add(client);
            _context.SaveChanges();
        }
    }
}
