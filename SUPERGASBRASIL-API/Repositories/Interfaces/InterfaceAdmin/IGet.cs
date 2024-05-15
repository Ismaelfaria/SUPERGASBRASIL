using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceAdmin
{
    public interface IGet
    {
        IEnumerable<Admin> FindAll();
        Admin FindByUserName(string name);
    }
}
