using AutoMapper;
using FluentValidation;
using SUPERGASBRASIL_API.App.Interfaces;
using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.App.Services.Interfaces;
using SUPERGASBRASIL_API.Domain;

namespace SUPERGASBRASIL_API.App.Services.ServicesImplementation
{
    public class ClientNaturalService : IClientNaturalService
    {
        private readonly IClientNaturalRepository client;
        private readonly IMapper mapper;
        private readonly IValidator<ClientNatural_InputModel> validator;

        public ClientNaturalService(
            IClientNaturalRepository client,
            IMapper mapper,
            IValidator<ClientNatural_InputModel> validator)
        {
            this.client = client;
            this.mapper = mapper;
            this.validator = validator;
        }

        public ClientNaturalPerson CreateClientNatural(ClientNatural_InputModel clientNatural)
        {
            var validResult = validator.Validate(clientNatural);

            if (!validResult.IsValid)
            {
                throw new ValidationException("Erro na validação ao criar o cliente");
            }

            var createMapObject = mapper.Map<ClientNaturalPerson>(clientNatural);

            createMapObject.IdClientNaturalPerson = Guid.NewGuid();
            var today = DateTime.Today;
            var birthDate = createMapObject.DateOfBirth;
            var age = today.Year - birthDate.Year;

            createMapObject.Age = age;

            client.Create(createMapObject);

            return createMapObject;
        }
        public void DeleteClientNatural(Guid id)
        {
            try
            {
                client.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir um cliente", ex);
            }
        }
        public IEnumerable<ClientNaturalPerson> FindAll()
        {
            try
            {
                var usersDatabase = client.GetAll();

                return usersDatabase;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro a buscar todos cliente", ex);
            }
        }

        public ClientNaturalPerson FindByCpf(string cpf)
        {
            try
            {
                var usersDatabase = client.FindByCpf(cpf);

                return usersDatabase;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro a buscar o cliente", ex);
            }
        }

        public ClientNaturalPerson FindByName(string name)
        {
            try
            {
                var usersDatabase = client.FindByName(name);

                return usersDatabase;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro a buscar o cliente", ex);
            }

        }

        public void UpdateClientNatural(string cpf, ClientNatural_InputModel clientNatural)
        {
            try
            {
                var createMapObject = mapper.Map<ClientNaturalPerson>(clientNatural);

                client.UpdateClientNatural(cpf, createMapObject);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir um cliente", ex);
            }
        }
    }
}
