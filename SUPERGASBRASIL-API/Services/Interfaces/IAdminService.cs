using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;

namespace SUPERGASBRASIL_API.Services.Interfaces
{
    public interface IAdminService
    {
        Admin CreateAdmin(Admin_InputModel adm);
        void DeleteAdmin(Guid id);
        IEnumerable<Admin> FindAll();
        Admin FindByUserName(string name);
        void UpdateAdmin(string userName, Admin_InputModel adm);

    }
}
