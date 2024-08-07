﻿using AutoMapper;
using FluentValidation;
using SUPERGASBRASIL_API.App.Interfaces;
using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.App.Services.Interfaces;
using SUPERGASBRASIL_API.Domain;
using SUPERGASBRASIL_API.Domain.Enum;

namespace SUPERGASBRASIL_API.App.Services.ServicesImplementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _user;
        private readonly IMapper _mapper;
        private readonly IValidator<User_InputModel> _validator;

        public UserService(
            IUserRepository user,
            IMapper mapper,
            IValidator<User_InputModel> validator)
        {
            _user = user;
            _mapper = mapper;
            _validator = validator;
        }

        public User Create(User_InputModel user)
        {

            var validResult = _validator.Validate(user);

            if (!validResult.IsValid)
            {
                throw new ValidationException("Erro na validação ao criar o usuario");
            }

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
            var Dados = _user.GetAll();

            return Dados;
        }
        public User FindByUserName(string name)
        {
            var Dados = _user.FindByUserName(name);

            return Dados;
        }
    }
}
