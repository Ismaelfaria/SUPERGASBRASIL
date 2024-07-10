using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.App.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGasTest.ClassValidation_Test
{
    public class InventoryValidation_Test
    {
        [Fact]
        public void Test_ValidacaoAdmin_Success()
        {
            var inputMock = new Inventory_InputModel
            {
                IdProduct = Guid.NewGuid(),
               Quantity = 1
            };

            var valid = new Inventory_InputValidator();
            var result = valid.Validate(inputMock);

            Assert.True(result.IsValid);
        }

        [Fact]
        public void Test_ValidacaoAdmin_ErroGuid()
        {
            var inputMock = new Inventory_InputModel
            {
                IdProduct = Guid.Empty,
                Quantity = 1
            };

            var valid = new Inventory_InputValidator();
            var result = valid.Validate(inputMock);

            Assert.False(result.IsValid);
        }
    }
}
