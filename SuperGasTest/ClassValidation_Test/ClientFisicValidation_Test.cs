using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.App.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGasTest.ClassValidation_Test
{
    public class ClientFisicValidation_Test
    {
        [Fact]
        public void Test_ValidacaoClientFisic_Success()
        {
            var inputMock = new ClientLegal_InputModel
            {
                Name = "name",
                ContactInformation = 111111111,
                TaxIdentificationNumberCNPJ = "11111111111111"
            };

            var valid = new ClientLegal_InputValidator();
            var result = valid.Validate(inputMock);

            Assert.True(result.IsValid);
        }

        [Fact]
        public void Test_ValidacaoClientFisic_ErroName()
        {
            var inputMock = new ClientLegal_InputModel
            {
                Name = "",
                ContactInformation = 111111111,
                TaxIdentificationNumberCNPJ = "11111111111111"
            };

            var valid = new ClientLegal_InputValidator();
            var result = valid.Validate(inputMock);

            Assert.False(result.IsValid);
        }
        
        [Fact]
        public void Test_ValidacaoClientFisic_ErroCNPJ()
        {
            var inputMock = new ClientLegal_InputModel
            {
                Name = "name",
                ContactInformation = 111111111,
                TaxIdentificationNumberCNPJ = ""
            };

            var valid = new ClientLegal_InputValidator();
            var result = valid.Validate(inputMock);

            Assert.False(result.IsValid);
        }
    }
}
