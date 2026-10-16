namespace StrategyPattern.StrategyPattern
{
    public class YurticiShippingStrategy : IShippingStrategy
    {
        public string CompanyName => "Yurtici Kargo";
        public decimal CalculateCost(decimal orderTotal)
        {
            return (orderTotal * 0.10m) + 20m;
        }
    
    }
}
