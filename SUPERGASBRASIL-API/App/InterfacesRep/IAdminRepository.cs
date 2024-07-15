using SUPERGASBRASIL_API.App.InterfacesRep;
using SUPERGASBRASIL_API.Domain;

namespace SUPERGASBRASIL_API.App.Interfaces
{
    public interface IAdminRepository : IRepository<Admin>
    {
        Admin FindByUserName(string name);
        void UpdateAdmin(string userName, Admin adm);
    }
}
