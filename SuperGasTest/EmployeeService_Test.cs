using AutoMapper;
using FluentValidation;
using Moq;
using SUPERGASBRASIL_API.App.Interfaces;
using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.App.Services.ServicesImplementation;
using SUPERGASBRASIL_API.Domain;
using SUPERGASBRASIL_API.Domain.Enum;

namespace SuperGasTest
{
    public class EmployeeService_Test
    {
        [Fact]
        public void FindAll_ReturnsValidEmployees()
        {
            var mockEmployeeRepository = new Mock<IEmployeeRepository>();
            var mockMapper = new Mock<IMapper>();
            var mockValidator = new Mock<IValidator<Employees_InputModel>>();

            mockEmployeeRepository.Setup(repo => repo.FindAll())
                .Returns(new List<Employees>
                {
                    new Employees {

                    IdEmployees = Guid.NewGuid(),
                    Name = "ismael",
                    Age = 34,
                    Cpf = 12345678912,
                    DateOfBirth = new DateTime(1990, 5, 15),
                    Position = EPositions.Gerente,
                    Positions = "Gerente",
                    Salary = 1200,
                    HireDate = new DateTime(2015, 8, 11),
                    IsDeleted = false},
                    new Employees {

                    IdEmployees = Guid.NewGuid(),
                    Name = "ismael",
                    Age = 34,
                    Cpf = 12345678912,
                    DateOfBirth = new DateTime(1990, 5, 15),
                    Position = EPositions.Gerente,
                    Positions = "Gerente",
                    Salary = 1200,
                    HireDate = new DateTime(2015, 8, 11),
                    IsDeleted = false},
                    new Employees {

                    IdEmployees = Guid.NewGuid(),
                    Name = "ismael",
                    Age = 34,
                    Cpf = 12345678912,
                    DateOfBirth = new DateTime(1990, 5, 15),
                    Position = EPositions.Gerente,
                    Positions = "Gerente",
                    Salary = 1200,
                    HireDate = new DateTime(2015, 8, 11),
                    IsDeleted = false}
                });

            var employeeService = new EmployeeService(mockEmployeeRepository.Object, mockMapper.Object, mockValidator.Object);

            var employees = employeeService.FindAll();

            Assert.NotNull(employees);
            Assert.Equal(3, employees.Count());
        }
    }
}
