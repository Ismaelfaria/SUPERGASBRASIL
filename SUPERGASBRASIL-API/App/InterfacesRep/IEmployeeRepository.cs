using SUPERGASBRASIL_API.Domain;

namespace SUPERGASBRASIL_API.App.InterfacesRep
{
    public interface IEmployeeRepository : IRepository<Employees>
    {
        Employees FindByCpf(long cpf);
        Employees FindByName(string name);
        void UpdateEmployee(long cpf, Employees funcionario);
    }
}
