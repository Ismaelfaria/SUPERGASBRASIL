using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Employees CreateEmployee(Employees funcionario);
        void DeleteEmployee(Guid id);
        void UpdateEmployee(string cpf, Employees funcionario);
        IEnumerable<Employees> FindAll();
        Employees FindByCpf(string cpf);
        Employees FindByName(string name);
    }
}
