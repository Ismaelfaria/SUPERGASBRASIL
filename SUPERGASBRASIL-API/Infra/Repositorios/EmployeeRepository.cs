using SUPERGASBRASIL_API.App.Interfaces;
using SUPERGASBRASIL_API.Domain;
using SUPERGASBRASIL_API.Infra.Context;

namespace SUPERGASBRASIL_API.Infra.Repositorios
{
    public class EmployeeRepository : RepositoryBase<Employees>
    {
        public EmployeeRepository(GasContext context) : base(context)
        {
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
