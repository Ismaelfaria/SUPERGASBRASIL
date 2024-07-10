using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.App.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGasTest.ClassValidation_Test
{
    public class ClientValidation_Test
    {
        [Fact]
        public void Test_ValidacaoClient_Success()
        {
            var inputMock = new ClientNatural_InputModel
            {
                Name = "name",
                CPF = "11111111111"
            };

            var valid = new ClientNatural_InputValidator();
            var result = valid.Validate(inputMock);

            Assert.True(result.IsValid);
        }

        [Fact]
        public void Test_ValidacaoClient_ErroCPF()
        {
            var inputMock = new ClientNatural_InputModel
            {
                Name = "name",
                CPF = ""
            };

            var valid = new ClientNatural_InputValidator();
            var result = valid.Validate(inputMock);

            Assert.False(result.IsValid);
        }

        [Fact]
        public void Test_ValidacaoClient_ErroName()
        {
            var inputMock = new ClientNatural_InputModel
            {
                Name = "",
                CPF = "11111111111"
            };

            var valid = new ClientNatural_InputValidator();
            var result = valid.Validate(inputMock);

            Assert.False(result.IsValid);
        }
    }
}
