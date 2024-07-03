using AutoMapper;
using FluentValidation;
using SUPERGASBRASIL_API.App.Interfaces;
using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.App.Services.Interfaces;
using SUPERGASBRASIL_API.Domain;

namespace SUPERGASBRASIL_API.App.Services.ServicesImplementation
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _admin;
        private readonly IValidator<Admin_InputModel> _validator;
        private readonly IMapper _mapper;

        public AdminService(
            IAdminRepository admin,
            IValidator<Admin_InputModel> validator,
            IMapper mapper)
        {
            _admin = admin;
            _validator = validator;
            _mapper = mapper;
        }

        public Admin CreateAdmin(Admin_InputModel admin)
        {
            var validResult = _validator.Validate(admin);

            if (!validResult.IsValid)
            {
                throw new ValidationException("Erro na validação ao criar o admin");
            }

            var createMapObject = _mapper.Map<Admin>(admin);

            createMapObject.IdAdmin = Guid.NewGuid();

            var createdItem = _admin.CreateAdmin(createMapObject);

            return createdItem;
        }
        public void DeleteAdmin(Guid id)
        {
            _admin.DeleteAdmin(id);
        }
        public IEnumerable<Admin> FindAll()
        {
            var Dados = _admin.FindAll();

            return Dados;
        }
        public Admin FindByUserName(string name)
        {
            var Dados = _admin.FindByUserName(name);

            return Dados;
        }
        public void UpdateAdmin(string userName, Admin_InputModel admin)
        {
            var createMapObject = _mapper.Map<Admin>(admin);

            _admin.UpdateAdmin(userName, createMapObject);
        }
    }
}
