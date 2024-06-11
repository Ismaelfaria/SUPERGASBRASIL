using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryEmployee
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly GasContext _context;

        public EmployeeRepository(GasContext context)
        {
            _context = context;
        }

        public Employees CreateEmployee(Employees employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();

            return employee;
        }
        public void DeleteEmployee(Guid id)
        {
            var userDatabase = _context.Employees.SingleOrDefault(a => a.IdEmployees == id);

            userDatabase.Deleted();
            _context.SaveChanges();
        }
        public IEnumerable<Employees> FindAll()
        {
            var usersDatabase = _context.Employees.Where(a => !a.IsDeleted).ToList();

            return usersDatabase;
        }

        public Employees FindByCpf(long cpf)
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
        public void UpdateEmployee(long cpf, Employees employee)
        {
            var userDatabase = _context.Employees.SingleOrDefault(a => a.Cpf == cpf);

            userDatabase.Update(employee.Cpf, employee.Name, employee.Age, employee.DateOfBirth, employee.Position, employee.Salary, employee.HireDate);
            _context.SaveChanges();
        }
    }
}
