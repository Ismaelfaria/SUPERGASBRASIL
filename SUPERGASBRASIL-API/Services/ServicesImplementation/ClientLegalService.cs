﻿using AutoMapper;
using FluentValidation;
using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Entities.Enum;
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

            createMapObject.IdClientLegalEntity = Guid.NewGuid();

            switch (clientLegal.TypeOfCompany)
            {
                case ESizeOfCompanies.MEI:
                    createMapObject.TypeCompany = "MEI";
                    break;

                case ESizeOfCompanies.EPP:
                    createMapObject.TypeCompany = "EPP";
                    break;

                case ESizeOfCompanies.ME:
                    createMapObject.TypeCompany = "ME";
                    break;

                case ESizeOfCompanies.GE:
                    createMapObject.TypeCompany = "GE";
                    break;

                case ESizeOfCompanies.MP:
                    createMapObject.TypeCompany = "MP";
                    break;

            }

            var c = client.CreateClientLegal(createMapObject);

            return c;

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

        public ClientLegalEntity FindByCnpj(long cnpj)
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
        public void UpdateClientLegal(long cnpj, ClientLegal_InputModel clientLegal)
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
