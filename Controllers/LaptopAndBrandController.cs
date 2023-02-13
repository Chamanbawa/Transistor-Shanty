using Microsoft.AspNetCore.Mvc;
using Transistor_Shanty.Data;
using Transistor_Shanty.Models;

namespace Transistor_Shanty.Controllers
{
    public class LaptopAndBrandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ExpensiveLaptops()
        {
            int maxPrice = Database.Laptops.Max(point => point.Price);
            Laptop laptop = Database.Laptops.Where(point => point.Price == maxPrice).First();

            return View("checking", laptop);

        }
    }
}
