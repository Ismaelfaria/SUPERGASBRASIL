using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceAdmin;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceAdmin;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesAdmin
{
    public class Create : ICreateServ
    {
        private readonly ICreate Admin;
        public Create(ICreate admin)
        {
            Admin = admin;
        }
        public void CreateAdmin(Admin admin)
        {
            Admin.CreateAdmin(admin);
        }
    }
}
