﻿using AutoMapper;
using FluentValidation;
using SUPERGASBRASIL_API.App.Interfaces;
using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.App.Rest.Interface;
using SUPERGASBRASIL_API.App.Services.Interfaces;
using SUPERGASBRASIL_API.Domain;
using System.Net;

namespace SUPERGASBRASIL_API.App.Services.ServicesImplementation
{
    public class ClientLegalService : IClientLegalService
    {
        private readonly IClientLegalRepository client;
        private readonly IBrasilAPI brasilApi;
        private readonly IMapper mapper;
        private readonly IValidator<ClientLegal_InputModel> validator;

        public ClientLegalService(
            IClientLegalRepository client,
            IBrasilAPI brasilApi,
            IMapper mapper,
            IValidator<ClientLegal_InputModel> validator)
        {
            this.client = client;
            this.brasilApi = brasilApi;
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

            createMapObject.Name = clientLegal.Name;

            var cnpjResponse = brasilApi.BuscarCNPJ(createMapObject.TaxIdentificationNumberCNPJ.ToString()).Result;
            if (cnpjResponse.CodigoHttp == HttpStatusCode.OK)
            {
                createMapObject.CnpjInfo = cnpjResponse.DadosRetorno;
            }
            else
            {
                throw new Exception("Erro ao buscar informações do CNPJ");
            }

            var c = client.Create(createMapObject);

            return c;

        }
        public void DeleteClientLegal(Guid id)
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
        public IEnumerable<ClientLegalEntity> FindAll()
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
