using SUPERGASBRASIL_API.Entities.PIT;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;

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
