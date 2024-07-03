using SUPERGASBRASIL_API.App.Mapping.Models.InputModel;
using SUPERGASBRASIL_API.Domain.PIT;

namespace SUPERGASBRASIL_API.Services.Interfaces.PIT_ServicesInterfaces
{
    public interface IProductService
    {
        Product CreateProduct(Product_InputModel product);
        void DeleteProduct(Guid id);
        IEnumerable<Product> FindAll();
        Product FindByIdProduct(Guid id);
        void UpdateProduct(Guid id, Product_InputModel product);
    }
}
