using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Repositories.Interfaces;

namespace SUPERGASBRASIL_API.Repositories.Repositorios
{
    public class EmployeesRepository : IEmployeesRepository
    {
        public void Create(Employees funcionario)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employees> FindAll()
        {
            throw new NotImplementedException();
        }

        public Employees FindByCpf(int cpf)
        {
            throw new NotImplementedException();
        }

        public Employees FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(int cpf, Employees funcionario)
        {
            throw new NotImplementedException();
        }
    }
}
