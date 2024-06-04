using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Services.Interfaces
{
    public interface IUserService
    {
        User Create(User user);
        void Delete(Guid id);
        IEnumerable<User> FindAll();
        User FindByUserName(string name);
    }
}
