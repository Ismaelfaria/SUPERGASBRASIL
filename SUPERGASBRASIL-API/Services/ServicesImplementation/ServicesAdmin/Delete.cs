using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceAdmin;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceAdmin;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesAdmin
{
    public class Delete : IDeleteServ
    {
        private readonly IDeleteA Deleted;
        public Delete(IDeleteA deleted)
        {
            Deleted = deleted;
        }
        public void DeleteAdmin(Guid id)
        {
            Deleted.DeleteAdmin(id);
        }
    }
}
