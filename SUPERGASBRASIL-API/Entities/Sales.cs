using SUPERGASBRASIL_API.Entities.GasStock;

namespace SUPERGASBRASIL_API.Entities
{
    public class Sales
    {
        public Guid IdSales { get; set; }
        public string ClientName { get; set; }
        public int Quantity { get; set; }
        //Menu de Selecão para fazer a logica do tipo de gas
        public string Type { get; set; }
        public DateTime TimeOfSale { get; set; }
        public bool IsDeleted { get; set; }

        public void Deleted()
        {
            IsDeleted = true;
        }
    }
}
