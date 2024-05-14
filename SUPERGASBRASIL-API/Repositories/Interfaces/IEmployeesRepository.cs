using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces
{
    public interface IEmployeesRepository
    {
        void Create(Employees funcionario);
        void Delete(Guid id);
        IEnumerable<Employees> FindAll();
        Employees FindByCpf(int cpf);
        Employees FindByName(string name);
        void Update(int cpf, Employees funcionario);
    }
}
