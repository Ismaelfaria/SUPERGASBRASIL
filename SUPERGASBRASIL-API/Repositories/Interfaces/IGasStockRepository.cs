using SUPERGASBRASIL_API.Entities.GasStock;

namespace SUPERGASBRASIL_API.Repositories.Interfaces
{
    public interface IGasStockRepository
    {
        Gas CreateQtdGasStock(Gas gas);
        void DeleteQtdGasIndStock(int qtd);
        void DeleteQtdGasCozStock(int qtd);
    }
}
