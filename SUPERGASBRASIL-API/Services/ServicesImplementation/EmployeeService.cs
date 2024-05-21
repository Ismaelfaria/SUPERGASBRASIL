using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Repositories.Interfaces;
using SUPERGASBRASIL_API.Services.Interfaces;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository Employee;

        public EmployeeService(IEmployeeRepository employee)
        {
            Employee = employee;
        }

        public Employees CreateEmployee(Employees employee)
        {
            Employee.CreateEmployee(employee);

            return employee;
        }
        public void DeleteEmployee(Guid id)
        {
            Employee.DeleteEmployee(id);
        }
        public IEnumerable<Employees> FindAll()
        {
            var usersDatabase = Employee.FindAll();

            return usersDatabase;
        }

        public Employees FindByCpf(int cpf)
        {
            var usersDatabase = Employee.FindByCpf(cpf);

            return usersDatabase;
        }

        public Employees FindByName(string name)
        {
            var usersDatabase = Employee.FindByName(name);

            return usersDatabase;

        }
        public void UpdateEmployee(int cpf, Employees employee)
        {
            Employee.UpdateEmployee(cpf, employee);
        }
    }
}
