using AutoMapper;
using FluentValidation;
using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Entities.PIT;
using SUPERGASBRASIL_API.Mappers.Models.InputModel;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.PIT_RepositoryInterfaces;
using SUPERGASBRASIL_API.Services.Interfaces.PIT_ServicesInterfaces;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.PIT_Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _prod;
        private readonly IMapper _map;
        private readonly IValidator<Product_InputModel> validator;

        public ProductService(
            IProductRepository prod, 
            IMapper map, 
            IValidator<Product_InputModel> validator)
        {
            _prod = prod;
            _map = map;
            this.validator = validator;
        }

        public Product CreateProduct(Product_InputModel product)
        {
            var validResult = validator.Validate(product);

            if (!validResult.IsValid)
            {
                throw new ValidationException("Erro na validação ao criar o produto");
            }

            var createMapObject = _map.Map<Product>(product);

            createMapObject.IdProduct = Guid.NewGuid();

            _prod.CreateProduct(createMapObject);

            return createMapObject;

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

        public void UpdateProduct(Guid id, Product_InputModel product)
        {
            var createMapObject = _map.Map<Product>(product);

            _prod.UpdateProduct(id, createMapObject);
        }
    }
}
