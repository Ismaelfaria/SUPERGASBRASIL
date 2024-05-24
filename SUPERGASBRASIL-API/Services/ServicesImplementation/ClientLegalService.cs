using AutoMapper;
using FluentValidation;
using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;
using SUPERGASBRASIL_API.Repositories.Interfaces;
using SUPERGASBRASIL_API.Services.Interfaces;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation
{
    public class ClientLegalService : IClientLegalService
    {
        private readonly IClientLegalRepository client;
        private readonly IMapper mapper;
        private readonly IValidator<ClientLegal_InputModel> validator;

        public ClientLegalService(IClientLegalRepository client, IMapper mapper, IValidator<ClientLegal_InputModel> validator)
        {
            this.client = client;
            this.mapper = mapper;
            this.validator = validator;
        }

        public ClientLegalEntity CreateClientLegal(ClientLegal_InputModel clientLegal)
        {
           

            var validResult = validator.Validate(clientLegal);

            if (!validResult.IsValid)
            {
                throw new ValidationException("Erro na validação ao criar o cliente");
            }

            var createMapObject = mapper.Map<ClientLegalEntity>(clientLegal);

            client.CreateClientLegal(createMapObject);

            return createMapObject;
        }
        public void DeleteClientLegal(Guid id)
        {
            try
            {

                client.DeleteClientLegal(id);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir um cliente", ex);
            }
        }
        public IEnumerable<ClientLegalEntity> FindAll()
        {
            try
            {
                var usersDatabase = client.FindAll();

                return usersDatabase;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro a buscar todos cliente", ex);
            }
        }

        public ClientLegalEntity FindByCnpj(string cnpj)
        {
            try
            {
                var usersDatabase = client.FindByCnpj(cnpj);

                return usersDatabase;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro a buscar o cliente", ex);
            }
        }

        public ClientLegalEntity FindByCompanyName(string name)
        {
            try
            {
                var usersDatabase = client.FindByCompanyName(name);

                return usersDatabase;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro a buscar o cliente", ex);
            }
        }
        public void UpdateClientLegal(string cnpj, ClientLegal_InputModel clientLegal)
        {
            try
            {
                var createMapObject = mapper.Map<ClientLegalEntity>(clientLegal);

                client.UpdateClientLegal(cnpj, createMapObject);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir um cliente", ex);
            }
        }
    }
}
