namespace StrategyPattern.StrategyPattern
{
    public class ArasShippingStrategy : IShippingStrategy
    {
        public string CompanyName => "Aras Kargo";
        public decimal CalculateCost(decimal orderTotal)
        {
            return (orderTotal * 0.15m) + 25m;
        }
    
    }
}
