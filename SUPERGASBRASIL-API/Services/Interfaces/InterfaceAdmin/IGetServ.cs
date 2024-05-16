using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Services.Interfaces.InterfaceAdmin
{
    public interface IGetServ
    {
        IEnumerable<Admin> FindAll();
        Admin FindByUserName(string name);
    }
}
