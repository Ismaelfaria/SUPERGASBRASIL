using AutoMapper;
using FluentValidation;
using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;
using SUPERGASBRASIL_API.Repositories.Interfaces;
using SUPERGASBRASIL_API.Services.Interfaces;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository Employee;
        private readonly IMapper mapper;
        private readonly IValidator<Employees_InputModel> validator;

        public EmployeeService(IEmployeeRepository employee, IMapper mapper, IValidator<Employees_InputModel> validator)
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

            Employee.CreateEmployee(createMapObject);

            return createMapObject;
        }
        public void DeleteEmployee(Guid id)
        {
            try
            {
                Employee.DeleteEmployee(id);
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
                var usersDatabase = Employee.FindAll();

                return usersDatabase;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro a buscar todos od funcionarios", ex);
            }
        }

        public Employees FindByCpf(string cpf)
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
        public void UpdateEmployee(string cpf, Employees_InputModel employee)
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
