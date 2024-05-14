namespace SUPERGASBRASIL_API.Entities
{
    public class GeneralReport
    {
        public Guid IdReport { get; set; }
        public int KitchenGasQuantity { get; set; }
        public int IndustrialGasQuantity { get; set; }
        public int SalesValue { get; set; }
        public int RefillKitchenGas { get; set; }
        public int RefillIndustrialGas { get; set; }
        public DateTime DateGenerated { get; set; }

        public GeneralReport(int kitchenGasQuantity, int industrialGasQuantity, int salesValue, int refillKitchenGas, int refillIndustrialGas)
        {
            KitchenGasQuantity = kitchenGasQuantity;
            IndustrialGasQuantity = industrialGasQuantity;
            SalesValue = salesValue;
            RefillKitchenGas = refillKitchenGas;
            RefillIndustrialGas = refillIndustrialGas;
        }
    }
}
