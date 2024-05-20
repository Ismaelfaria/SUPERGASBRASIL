namespace SUPERGASBRASIL_API.Mappers.Models.ViewModel
{
    public class GeneralReport_ViewModel
    {
        public Guid IdReport { get; set; }
        public int KitchenGasQuantity { get; set; }
        public int IndustrialGasQuantity { get; set; }
        public int SalesValue { get; set; }
        public int RefillKitchenGas { get; set; }
        public int RefillIndustrialGas { get; set; }
        public DateTime DateGenerated { get; set; }
    }
}
