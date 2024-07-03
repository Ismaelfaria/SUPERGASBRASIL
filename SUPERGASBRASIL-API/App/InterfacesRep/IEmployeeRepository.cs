using SUPERGASBRASIL_API.Domain;

namespace SUPERGASBRASIL_API.App.Interfaces
{
    public interface IEmployeeRepository
    {
        Employees CreateEmployee(Employees funcionario);
        void DeleteEmployee(Guid id);
        void UpdateEmployee(long cpf, Employees funcionario);
        IEnumerable<Employees> FindAll();
        Employees FindByCpf(long cpf);
        Employees FindByName(string name);
    }
}
