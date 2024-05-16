using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientLegal;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceClientLegal;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesClientLegal
{
    public class Delete : IDeleteServ
    {
        private readonly IDelete DeleteC;
        public Delete(IDelete deleteC)
        {
            DeleteC = deleteC;
        }
        public void DeleteClientLegal(Guid id)
        {
            DeleteC.DeleteClientLegal(id);
        }
    }
}
