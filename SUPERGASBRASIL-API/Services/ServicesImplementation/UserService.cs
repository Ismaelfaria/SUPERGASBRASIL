using AutoMapper;
using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Entities.Enum;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;
using SUPERGASBRASIL_API.Repositories.Interfaces;
using SUPERGASBRASIL_API.Services.Interfaces;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _user;
        private readonly IMapper _mapper;

        public UserService(IUserRepository user, IMapper mapper)
        {
            _user = user;
            _mapper = mapper;
        }

        public User Create(Login_InputModel user)
        {
            var createMapObject = _mapper.Map<User>(user);


            switch (createMapObject.Role)
            {
                case ERole.ADM:
                    createMapObject.Roles = "Admin";
                    break;

                case ERole.SECRETARIA:
                    createMapObject.Roles = "Secretaria";
                    break;

            }
            createMapObject.Id = Guid.NewGuid();
            var createdItem = _user.Create(createMapObject);

            return createMapObject;
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
