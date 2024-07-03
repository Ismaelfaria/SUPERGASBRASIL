namespace SUPERGASBRASIL_API.App.Mapping.Models.InputModel
{
    public class GeneralReport_InputModel
    {
        public int KitchenGasQuantity { get; set; }
        public int IndustrialGasQuantity { get; set; }
        public int SalesValue { get; set; }
        public int RefillKitchenGas { get; set; }
        public int RefillIndustrialGas { get; set; }
        public DateTime DateGenerated { get; set; }
    }
}
