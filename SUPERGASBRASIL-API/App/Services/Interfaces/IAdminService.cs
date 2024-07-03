using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.Domain;

namespace SUPERGASBRASIL_API.App.Services.Interfaces
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
