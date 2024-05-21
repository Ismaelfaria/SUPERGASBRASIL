using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces
{
    public interface IAdminRepository
    {
        Admin CreateAdmin(Admin adm);
        void DeleteAdmin(Guid id);
        IEnumerable<Admin> FindAll();
        Admin FindByUserName(string name);
        void UpdateAdmin(string userName, Admin adm);
    }
}
