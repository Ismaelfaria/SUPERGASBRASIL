using SUPERGASBRASIL_API.Entities.PIT;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.PIT_RepositoryInterfaces;
using SUPERGASBRASIL_API.Services.Interfaces.PIT_ServicesInterfaces;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.PIT_Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _prod;

        public ProductService(IProductRepository prod) 
        {
            _prod = prod;
        }

        public Product CreateProduct(Product product)
        {
            _prod.CreateProduct(product);

            return product;

        }

        public void DeleteProduct(Guid id)
        {
            _prod.DeleteProduct(id);
        }

        public IEnumerable<Product> FindAll()
        {
           return _prod.FindAll();
        }

        public Product FindByIdProduct(Guid id)
        {
            return _prod.FindByIdProduct(id);
        }

        public void UpdateProduct(Guid id, Product product)
        {
            _prod.UpdateProduct(id, product);
        }
    }
}
