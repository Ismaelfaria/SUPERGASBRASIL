using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.App.Validators;
using SUPERGASBRASIL_API.Domain.Enum;

namespace SuperGasTest
{
    public class EmployeeValidationTest
    {
        [Fact]
        public void Test_ValidacaoFuncionario_Success()
        {
            var inputMock = new Employees_InputModel
            {
                Name = "ismael",
                Cpf = 12345678912,
                DateOfBirth = new DateTime(1990, 5, 15),
                Position = EPositions.Gerente,
                Salary = 1200,
                HireDate = new DateTime(2015, 8, 11)
            };

            var valid = new Employee_InputValidator();
            var result = valid.Validate(inputMock);

            Assert.True(result.IsValid);
        }

        [Fact]
        public void Test_ValidacaoFuncionario_ErrorName()
        {
            var inputMock = new Employees_InputModel
            {
                Name = "",
                Cpf = 12345678912,
                DateOfBirth = new DateTime(1990, 5, 15),
                Position = EPositions.Gerente,
                Salary = 1200,
                HireDate = new DateTime(2015, 8, 11)
            };

            var valid = new Employee_InputValidator();
            var result = valid.Validate(inputMock);

            Assert.False(result.IsValid);
        }

        [Fact]
        public void Test_ValidacaoFuncionario_ErrorCpf()
        {
            var inputMock = new Employees_InputModel
            {
                Name = "ismael",
                DateOfBirth = new DateTime(1990, 5, 15),
                Position = EPositions.Gerente,
                Salary = 1200,
                HireDate = new DateTime(2015, 8, 11)
            };

            var valid = new Employee_InputValidator();
            var result = valid.Validate(inputMock);

            Assert.False(result.IsValid);
        }

        [Fact]
        public void Test_ValidacaoFuncionario_ErrorDateOfBirth()
        {
            var inputMock = new Employees_InputModel
            {
                Name = "ismael",
                Cpf = 12345678912,
                Position = EPositions.Gerente,
                Salary = 1200,
                HireDate = new DateTime(2015, 8, 11)
            };

            var valid = new Employee_InputValidator();
            var result = valid.Validate(inputMock);

            Assert.False(result.IsValid);
        }

        [Fact]
        public void Test_ValidacaoFuncionario_ErrorSalary()
        {
            var inputMock = new Employees_InputModel
            {
                Name = "ismael",
                Cpf = 12345678912,
                Position = EPositions.Gerente,
                DateOfBirth = new DateTime(1990, 5, 15),
                HireDate = new DateTime(2015, 8, 11)
            };

            var valid = new Employee_InputValidator();
            var result = valid.Validate(inputMock);

            Assert.False(result.IsValid);
        }
    }
}
