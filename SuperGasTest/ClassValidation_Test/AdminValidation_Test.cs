using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.App.Validators;
using SUPERGASBRASIL_API.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGasTest.ClassValidation_Test
{
    public class AdminValidation_Test
    {
        [Fact]
        public void Test_ValidacaoAdmin_Success()
        {
            var inputMock = new Admin_InputModel
            {
                Username = "Adm",
                Password = "password"
            };

            var valid = new Admin_InputValidator();
            var result = valid.Validate(inputMock);

            Assert.True(result.IsValid);
        }

        [Fact]
        public void Test_ValidacaoAdmin_ErroPassword()
        {
            var inputMock = new Admin_InputModel
            {
                Username = "Adm",
                Password = ""
            };

            var valid = new Admin_InputValidator();
            var result = valid.Validate(inputMock);

            Assert.False(result.IsValid);
        }

        [Fact]
        public void Test_ValidacaoAdmin_ErroUserName()
        {
            var inputMock = new Admin_InputModel
            {
                Username = "",
                Password = "password"
            };

            var valid = new Admin_InputValidator();
            var result = valid.Validate(inputMock);

            Assert.False(result.IsValid);
        }
    }
}
