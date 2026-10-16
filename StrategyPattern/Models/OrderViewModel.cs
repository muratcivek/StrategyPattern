namespace StrategyPattern.Models
{
    public class OrderViewModel
    {
        public decimal OrderTotal { get; set; }

        public string SelectedCargo { get; set; }

        public decimal? CalculatedShippingCost { get; set; }

        public decimal? GrandTotal => OrderTotal + (CalculatedShippingCost ?? 0);

    }
}
