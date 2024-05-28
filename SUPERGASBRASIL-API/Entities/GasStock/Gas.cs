namespace SUPERGASBRASIL_API.Entities.GasStock
{
    public class Gas
    {
        public int KitchenGasValue { get; set; }
        public int IndustrialGasValue { get; set; }

        public int ValueTotKitchenGas( int quantity)
        {
            KitchenGasValue = KitchenGasValue * quantity;

            return KitchenGasValue;
        }
        public int ValueTotIndustrialGas(int quantity)
        {
            IndustrialGasValue = IndustrialGasValue * quantity;

            return IndustrialGasValue;
        }
        public int ValueDelIndustrialGas(int quantity)
        {
            IndustrialGasValue = IndustrialGasValue - quantity;

            return IndustrialGasValue;
        }
        public int ValueDelKitchenGas(int quantity)
        {
            KitchenGasValue = KitchenGasValue - quantity;

            return KitchenGasValue;
        }
    }
}
