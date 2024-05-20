using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Services.Interfaces.InterfaceAdmin
{
    public interface IGetServA
    {
        IEnumerable<Admin> FindAll();
        Admin FindByUserName(string name);
    }
}
