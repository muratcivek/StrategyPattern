namespace StrategyPattern.StrategyPattern
{
    public interface IShippingStrategy
    {
        public string CompanyName { get;}

        decimal CalculateCost(decimal orderTotal);

    }
}
