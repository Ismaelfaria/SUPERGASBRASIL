using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientLegal;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceClientLegal;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesClientLegal
{
    public class Delete : IDeleteServ
    {
        private readonly IDeleteClientL DeleteC;
        public Delete(IDeleteClientL deleteC)
        {
            DeleteC = deleteC;
        }
        public void DeleteClientLegal(Guid id)
        {
            DeleteC.DeleteClientLegal(id);
        }
    }
}
