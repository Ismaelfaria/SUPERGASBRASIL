using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceAdmin;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceAdmin;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesAdmin
{
    public class DeleteSA : IDeleteServA
    {
        private readonly IDeleteA Deleted;
        public DeleteSA(IDeleteA deleted)
        {
            Deleted = deleted;
        }
        public void DeleteAdmin(Guid id)
        {
            Deleted.DeleteAdmin(id);
        }
    }
}
