using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.Domain;

namespace SUPERGASBRASIL_API.App.Services.Interfaces
{
    public interface IUserService
    {
        User Create(User_InputModel user);
        void Delete(Guid id);
        IEnumerable<User> FindAll();
        User FindByUserName(string name);
    }
}
