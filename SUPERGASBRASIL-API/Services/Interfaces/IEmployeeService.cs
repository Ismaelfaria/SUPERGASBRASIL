using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Services.Interfaces
{
    public interface IEmployeeService
    {
        Employees CreateEmployee(Employees funcionario);
        void DeleteEmployee(Guid id);
        IEnumerable<Employees> FindAll();
        Employees FindByCpf(int cpf);
        Employees FindByName(string name);
        void UpdateEmployee(int cpf, Employees funcionario);

    }
}
