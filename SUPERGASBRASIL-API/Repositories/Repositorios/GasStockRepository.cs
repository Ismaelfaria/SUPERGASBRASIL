using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Entities.GasStock;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces;

namespace SUPERGASBRASIL_API.Repositories.Repositorios
{
    public class GasStockRepository : IGasStockRepository
    {
        private readonly GasContext _context;

        public GasStockRepository(GasContext context)
        {
            _context = context;
        }

        public Gas CreateQtdGasStock(Gas gas)
        {
            _context.Gas.Add(gas);
            _context.SaveChanges();

            return gas;
        }

        public void DeleteQtdGasIndStock(int qtd)
        {
            
        }
        public void DeleteQtdGasCozStock(int qtd)
        {
            
        }
    }
}
