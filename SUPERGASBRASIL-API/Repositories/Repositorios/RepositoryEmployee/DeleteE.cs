using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceEmployees;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryEmployee
{
    public class DeleteE : IDeleteE
    {
        private readonly GasContext _context;
        public DeleteE(GasContext context)
        {
            _context = context;
        }
        public void DeleteEmployee(Guid id)
        {
            var userDatabase = _context.Employees.SingleOrDefault(a => a.IdEmployees == id);

            userDatabase.Deleted();
            _context.SaveChanges();
        }
    }
}
