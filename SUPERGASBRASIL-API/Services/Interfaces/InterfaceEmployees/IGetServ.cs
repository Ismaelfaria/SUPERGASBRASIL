using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Services.Interfaces.InterfaceEmployees
{
    public interface IGetServ
    {
        IEnumerable<Employees> FindAll();
        Employees FindByCpf(int cpf);
        Employees FindByName(string name);
    }
}
