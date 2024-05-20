using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientLegal;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceClientLegal;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesClientLegal
{
    public class DeleteSCL : IDeleteServCL
    {
        private readonly IDeleteClientL DeleteC;
        public DeleteSCL(IDeleteClientL deleteC)
        {
            DeleteC = deleteC;
        }
        public void DeleteClientLegal(Guid id)
        {
            DeleteC.DeleteClientLegal(id);
        }
    }
}
