using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User Create(User user);
        void Delete(Guid id);
        IEnumerable<User> FindAll();
        User FindByUserName(string name);

    }
}
