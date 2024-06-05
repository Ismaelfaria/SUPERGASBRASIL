using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;

namespace SUPERGASBRASIL_API.Services.Interfaces
{
    public interface IUserService
    {
        User Create(User_InputModel user);
        void Delete(Guid id);
        IEnumerable<User> FindAll();
        User FindByUserName(string name);
    }
}
