using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Entities.Enum;
using SUPERGASBRASIL_API.Repositories.Interfaces;
using SUPERGASBRASIL_API.Services.Interfaces;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _user;

        public UserService(IUserRepository user)
        {
            _user = user;
        }

        public User Create(User user)
        {
            switch (user.Role)
            {
                case ERole.ADM:
                    user.Roles = "Admin";
                    break;

                case ERole.SECRETARIA:
                    user.Roles = "Secretaria";
                    break;

            }
            user.Id = Guid.NewGuid();
            var createdItem = _user.Create(user);

            return createdItem;
        }
        public void Delete(Guid id)
        {
            _user.Delete(id);
        }
        public IEnumerable<User> FindAll()
        {
            var Dados = _user.FindAll();

            return Dados;
        }
        public User FindByUserName(string name)
        {
            var Dados = _user.FindByUserName(name);

            return Dados;
        }
    }
}
