using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.App.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGasTest.ClassValidation_Test
{
    public class ProductValidation_Test
    {
        [Fact]
        public void Test_ValidacaoProduct_Success()
        {
            var inputMock = new Product_InputModel
            {
                name = "name",
                Description = "description",
                Price = 100
            };

            var valid = new Product_InputValidator();
            var result = valid.Validate(inputMock);

            Assert.True(result.IsValid);
        }

        [Fact]
        public void Test_ValidacaoProduct_ErroName()
        {
            var inputMock = new Product_InputModel
            {
                name = "",
                Description = "description",
                Price = 100
            };

            var valid = new Product_InputValidator();
            var result = valid.Validate(inputMock);

            Assert.False(result.IsValid);
        }

        [Fact]
        public void Test_ValidacaoProduct_ErroDescription()
        {
            var inputMock = new Product_InputModel
            {
                name = "name",
                Description = "",
                Price = 100
            };

            var valid = new Product_InputValidator();
            var result = valid.Validate(inputMock);

            Assert.False(result.IsValid);
        }
    }
}
