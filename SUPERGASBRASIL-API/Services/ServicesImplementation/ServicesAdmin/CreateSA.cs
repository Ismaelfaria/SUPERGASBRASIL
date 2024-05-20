using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceAdmin;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceAdmin;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesAdmin
{
    public class CreateSA : ICreateServA
    {
        private readonly ICreateA Admin;
        public CreateSA(ICreateA admin)
        {
            Admin = admin;
        }
        public Admin CreateAdmin(Admin admin)
        {

           var createdItem = Admin.CreateAdmin(admin);

            return createdItem;
        }
    }
}
