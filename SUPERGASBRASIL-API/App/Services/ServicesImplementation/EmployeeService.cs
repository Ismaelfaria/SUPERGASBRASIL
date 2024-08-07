﻿using AutoMapper;
using FluentValidation;
using SUPERGASBRASIL_API.App.Interfaces;
using SUPERGASBRASIL_API.App.InterfacesRep;
using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.App.Services.Interfaces;
using SUPERGASBRASIL_API.Domain;
using SUPERGASBRASIL_API.Domain.Enum;

namespace SUPERGASBRASIL_API.App.Services.ServicesImplementation
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository Employee;
        private readonly IMapper mapper;
        private readonly IValidator<Employees_InputModel> validator;

        public EmployeeService(
            IEmployeeRepository employee,
            IMapper mapper,
            IValidator<Employees_InputModel> validator)
        {
            Employee = employee;
            this.mapper = mapper;
            this.validator = validator;
        }

        public Employees CreateEmployee(Employees_InputModel employee)
        {
            var validResult = validator.Validate(employee);

            if (!validResult.IsValid)
            {
                throw new ValidationException("Erro na validação ao criar o cliente");
            }

            var createMapObject = mapper.Map<Employees>(employee);

            switch (createMapObject.Position)
            {
                case EPositions.Repositor:
                    createMapObject.Positions = "repositor";
                    break;

                case EPositions.Secretaria:
                    createMapObject.Positions = "secretaria";
                    break;

                case EPositions.Fixina:
                    createMapObject.Positions = "faxina";
                    break;

                case EPositions.Gerente:
                    createMapObject.Positions = "gerente";
                    break;
            }

            createMapObject.IdEmployees = Guid.NewGuid();

            createMapObject.Age = DateTime.Now.Year - createMapObject.DateOfBirth.Year;

            Employee.Create(createMapObject);

            return createMapObject;
        }
        public void DeleteEmployee(Guid id)
        {
            try
            {
                Employee.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir um funcionario", ex);
            }
        }
        public IEnumerable<Employees> FindAll()
        {
            try
            {
                var usersDatabase = Employee.GetAll();

                return usersDatabase;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro a buscar todos od funcionarios", ex);
            }
        }

        public Employees FindByCpf(long cpf)
        {
            try
            {
                var usersDatabase = Employee.FindByCpf(cpf);

                return usersDatabase;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro a buscar o funcionario", ex);
            }
        }

        public Employees FindByName(string name)
        {
            try
            {
                var usersDatabase = Employee.FindByName(name);

                return usersDatabase;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro a buscar o funcionario", ex);
            }

        }
        public void UpdateEmployee(long cpf, Employees_InputModel employee)
        {
            try
            {
                var createMapObject = mapper.Map<Employees>(employee);
                Employee.UpdateEmployee(cpf, createMapObject);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir um cliente", ex);
            }
        }
    }
}
