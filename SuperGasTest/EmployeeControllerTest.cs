using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SUPERGASBRASIL_API.Controllers;
using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;
using SUPERGASBRASIL_API.Services.Interfaces;

namespace SuperGasTest
{
    public class EmployeeControllerTest
    {
        [Fact]
        public void Test_CriarFuncionario_Success()
        {
            // Arrange
            var employeeServiceMock = new Mock<IEmployeeService>();
            var mapperMock = new Mock<IMapper>();
            var controller = new EmployeeController(employeeServiceMock.Object, mapperMock.Object);

            var inputModel = new Employees_InputModel
            {
                Name = "ismael",
                Cpf = 12345678912,
                DateOfBirth = new DateTime(1990, 5, 15),
                Position = SUPERGASBRASIL_API.Entities.Enum.EPositions.Gerente,
                Salary = 1200,
                HireDate = new DateTime(2015, 8, 11)
            };

            var createdEmployee = new Employees
            {
                IdEmployees = Guid.NewGuid(),
                Name = "ismael",
                Age = 34,
                Cpf = 12345678912,
                DateOfBirth = new DateTime(1990, 5, 15),
                Position = SUPERGASBRASIL_API.Entities.Enum.EPositions.Gerente,
                Positions = "Gerente",
                Salary = 1200,
                HireDate = new DateTime(2015, 8, 11),
                IsDeleted = false
            };

            employeeServiceMock.Setup(e => e.CreateEmployee(inputModel)).Returns(createdEmployee);

            // Act
            var result = controller.CriarFuncionario(inputModel);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<CreatedAtActionResult>(result);
            Assert.Equal("ismael", createdEmployee.Name);
            // Verifique outras condições conforme necessário
        }

        // Adicione mais testes conforme necessário
    }
}
    
