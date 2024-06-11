using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;

namespace SUPERGASBRASIL_API.Services.Interfaces
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
