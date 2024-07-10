using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.App.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGasTest.ClassValidation_Test
{
    public class UserValidation_Test
    {
        [Fact]
        public void Test_ValidacaoUser_Success()
        {
            var inputMock = new User_InputModel
            {
                Username = "name",
                Password = "password",
                Role = SUPERGASBRASIL_API.Domain.Enum.ERole.SECRETARIA
            };

            var valid = new User_InputValidator();
            var result = valid.Validate(inputMock);

            Assert.True(result.IsValid);
        }

        [Fact]
        public void Test_ValidacaoUser_ErroName()
        {
            var inputMock = new User_InputModel
            {
                Username = "",
                Password = "password",
                Role = SUPERGASBRASIL_API.Domain.Enum.ERole.ADM
            };

            var valid = new User_InputValidator();
            var result = valid.Validate(inputMock);

            Assert.False(result.IsValid);
        }

        [Fact]
        public void Test_ValidacaoUser_ErroPassword()
        {
            var inputMock = new User_InputModel
            {
                Username = "name",
                Password = "",
                Role = SUPERGASBRASIL_API.Domain.Enum.ERole.ADM
            };

            var valid = new User_InputValidator();
            var result = valid.Validate(inputMock);

            Assert.False(result.IsValid);
        }
    }
}
