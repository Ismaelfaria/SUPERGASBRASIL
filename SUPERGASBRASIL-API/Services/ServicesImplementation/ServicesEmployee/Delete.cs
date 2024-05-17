using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceEmployees;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceEmployees;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesEmployee
{
    public class Delete : IDeleteServ
    {
        private readonly IDeleteE DeleteE;
        public Delete(IDeleteE deleteE)
        {
            DeleteE = deleteE;
        }
        public void DeleteEmployee(Guid id)
        {
            DeleteE.DeleteEmployee(id);
        }
    }
}
