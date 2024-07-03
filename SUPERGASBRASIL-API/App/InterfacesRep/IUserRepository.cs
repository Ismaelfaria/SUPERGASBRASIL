using SUPERGASBRASIL_API.Domain;

namespace SUPERGASBRASIL_API.App.Interfaces
{
    public interface IUserRepository
    {
        User Create(User user);
        void Delete(Guid id);
        IEnumerable<User> FindAll();
        User FindByUserName(string name);

    }
}
