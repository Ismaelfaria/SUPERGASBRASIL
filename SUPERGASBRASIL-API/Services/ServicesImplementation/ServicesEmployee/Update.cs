using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceEmployees;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesEmployee
{
    public class Update : IUpdate
    {
        private readonly GasContext _context;
        public Update(GasContext context)
        {
            _context = context;
        }
        public void UpdateEmployee(int cpf, Employees employee)
        {
            var userDatabase = _context.Employees.SingleOrDefault(a => a.Cpf == cpf);

            userDatabase.Update(employee.Cpf, employee.Name, employee.Age, employee.DateOfBirth, employee.Position, employee.Salary, employee.HireDate);
            _context.SaveChanges();
        }
    }
}
