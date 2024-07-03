using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.Domain;

namespace SUPERGASBRASIL_API.App.Services.Interfaces
{
    public interface IEmployeeService
    {
        Employees CreateEmployee(Employees_InputModel funcionario);
        void DeleteEmployee(Guid id);
        IEnumerable<Employees> FindAll();
        Employees FindByCpf(long cpf);
        Employees FindByName(string name);
        void UpdateEmployee(long cpf, Employees_InputModel funcionario);

    }
}
