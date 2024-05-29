using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Entities.PIT;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.PIT_RepositoryInterfaces;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.PIT_Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly GasContext _context;

        public ProductRepository(GasContext context)
        {
            _context = context;
        }

        public Product CreateProduct(Product product)
        {
            _context.Product.Add(product);
            _context.SaveChanges();

            return product;
        }
        public void DeleteProduct(Guid id)
        {
            var userDatabase = _context.Product.SingleOrDefault(a => a.IdProduct == id);

            userDatabase.Delete();
            _context.SaveChanges();
        }

        public IEnumerable<Product> FindAll()
        {
            var usersDatabase = _context.Product.Where(a => !a.IsDeleted).ToList();

            return usersDatabase;
        }

        public Product FindByIdProduct(Guid id)
        {
            var userDatabase = _context.Product.SingleOrDefault(a => a.IdProduct == id);

            if (userDatabase == null)
            {
                return null;
            }

            return userDatabase;
        }
        public void UpdateProduct(Guid Id, Product product)
        {
            var userDatabase = _context.Product.SingleOrDefault(a => a.IdProduct == Id);

            userDatabase.UpdateProduct(product.Name, product.Description, product.Price);
            _context.SaveChanges();
        }
    }
}
