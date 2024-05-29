using SUPERGASBRASIL_API.Entities.PIT;

namespace SUPERGASBRASIL_API.Repositories.Interfaces.PIT_RepositoryInterfaces
{
    public interface IProductRepository
    {
        Product CreateProduct(Product product);
        void DeleteProduct(Guid id);
        IEnumerable<Product> FindAll();
        Product FindByIdProduct(Guid id);
        void UpdateProduct(Guid id, Product product);
    }
}
