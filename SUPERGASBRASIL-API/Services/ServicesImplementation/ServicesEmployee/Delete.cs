using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceEmployees;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesEmployee
{
    public class Delete : IDelete
    {
        private readonly GasContext _context;
        public Delete(GasContext context)
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
