using Microsoft.AspNetCore.Mvc;
using StrategyPattern.Models;
using StrategyPattern.StrategyPattern;

namespace StrategyPattern.Controllers
{
    public class OrderController : Controller
    {
        private readonly IEnumerable<IShippingStrategy> _strategies;

        public OrderController(IEnumerable<IShippingStrategy> strategies)
        {
            _strategies = strategies;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new OrderViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(OrderViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var selectedStrategy = _strategies.FirstOrDefault(
                x => x.CompanyName == model.SelectedCargo);

            if (selectedStrategy == null)
            {
                ModelState.AddModelError(
                    nameof(model.SelectedCargo),
                    "Geçerli bir kargo firması seçiniz.");

                return View(model);
            }

            model.CalculatedShippingCost =
                selectedStrategy.CalculateCost(model.OrderTotal);

            return View(model);
        }
    }
}