using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceEmployees;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryEmployee
{
    public class GetE : IGetE
    {
        private readonly GasContext _context;
        public GetE(GasContext context)
        {
            _context = context;
        }
        public IEnumerable<Employees> FindAll()
        {
            var usersDatabase = _context.Employees.Where(a => !a.IsDeleted).ToList();

            return usersDatabase;
        }

        public Employees FindByCpf(int cpf)
        {
            var userDatabase = _context.Employees.SingleOrDefault(a => a.Cpf == cpf);

            if (userDatabase == null)
            {
                return null;
            }

            return userDatabase;
        }

        public Employees FindByName(string name)
        {
            var userDatabase = _context.Employees.SingleOrDefault(a => a.Name == name);

            if (userDatabase == null)
            {
                return null;
            }

            return userDatabase;
        }
    }
}
