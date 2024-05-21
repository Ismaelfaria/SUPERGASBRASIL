using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Services.Interfaces
{
    public interface IAdminService
    {
        Admin CreateAdmin(Admin adm);
        void DeleteAdmin(Guid id);
        IEnumerable<Admin> FindAll();
        Admin FindByUserName(string name);
        void UpdateAdmin(string userName, Admin adm);

    }
}
