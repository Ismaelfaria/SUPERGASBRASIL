using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceEmployees;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryEmployee
{
    public class CreateE : ICreateE
    {
        private readonly GasContext _context;
        public CreateE(GasContext context)
        {
            _context = context;
        }
        public void CreateEmployee(Employees employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
    }
}
