using SUPERGASBRASIL_API.Entities.PIT;

namespace SUPERGASBRASIL_API.Services.Interfaces.PIT_ServicesInterfaces
{
    public interface IProductService
    {
        Product CreateProduct(Product product);
        void DeleteProduct(Guid id);
        IEnumerable<Product> FindAll();
        Product FindByIdProduct(Guid id);
        void UpdateProduct(Guid id, Product product);
    }
}
