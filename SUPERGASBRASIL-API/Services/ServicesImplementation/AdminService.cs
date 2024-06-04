using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Repositories.Interfaces;
using SUPERGASBRASIL_API.Services.Interfaces;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository Admin;

        public AdminService(IAdminRepository admin)
        {
            Admin = admin;
        }

        public Admin CreateAdmin(Admin admin)
        {
            admin.IdAdmin = Guid.NewGuid();

            var createdItem = Admin.CreateAdmin(admin);

            return createdItem;
        }
        public void DeleteAdmin(Guid id)
        {
            Admin.DeleteAdmin(id);
        }
        public IEnumerable<Admin> FindAll()
        {
            var Dados = Admin.FindAll();

            return Dados;
        }
        public Admin FindByUserName(string name)
        {
            var Dados = Admin.FindByUserName(name);

            return Dados;
        }
        public void UpdateAdmin(string userName, Admin admin)
        {
            Admin.UpdateAdmin(userName, admin);
        }
    }
}
