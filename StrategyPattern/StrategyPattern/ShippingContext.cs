namespace StrategyPattern.StrategyPattern
{
    public class ShippingContext
    {
        private  IShippingStrategy _shippingStrategy;

        public void SetStrategy(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public decimal ExecuteCalculation(decimal orderTotal)
        {
            if (_shippingStrategy == null)
            {
                throw new InvalidOperationException("Lütfen kargo stratejisi seçiniz.");
            }
            return _shippingStrategy.CalculateCost(orderTotal);
        }
    }
}
