using SUPERGASBRASIL_API.App.InterfacesRep;
using SUPERGASBRASIL_API.Domain;

namespace SUPERGASBRASIL_API.App.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User FindByUserName(string name);
    }
}
