using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Employees CreateEmployee(Employees funcionario);
        void DeleteEmployee(Guid id);
        void UpdateEmployee(int cpf, Employees funcionario);
        IEnumerable<Employees> FindAll();
        Employees FindByCpf(int cpf);
        Employees FindByName(string name);
    }
}
