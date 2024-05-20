namespace SUPERGASBRASIL_API.Mappers.Models.InputModel
{
    public class Admin_InputModel
    {
        public string ClientName { get; set; }
        public int Quantity { get; set; }
        //Menu de Selecão para fazer a logica do tipo de gas
        public string Type { get; set; }
        public DateTime TimeOfSale { get; set; }
    }
}
