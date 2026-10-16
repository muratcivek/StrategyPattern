namespace StrategyPattern.StrategyPattern
{
    public class DhlShippingStrategy: IShippingStrategy
    {
        public string CompanyName => "DHL";
        public decimal CalculateCost(decimal orderTotal)
        {
            return orderTotal >= 500m ? 0m : 75m;
        }
    
    }
}
    