using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using Transistor_Shanty.Data;
using Transistor_Shanty.Models;
using Transistor_Shanty.Models.ViewModel;
using static Transistor_Shanty.Data.Database;

namespace Transistor_Shanty.Controllers
{
    public class LaptopAndBrandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //top 2 expensive laptops
        public IActionResult ExpensiveLaptops()
        {
            IEnumerable<Laptop> expensivelaptop = Database.Laptops.OrderByDescending(laptop => laptop.Price).Take(2);

            return View("ListOfLaptops", expensivelaptop);

        }

        //top 3 cheapest laptops
        public IActionResult AffordableLaptops()
        {

            IEnumerable<Laptop> affordablelaptops = Database.Laptops.OrderBy(laptop => laptop.Price).Take(3);
            return View("ListOfLaptops", affordablelaptops);
        }

        public IActionResult AffordableLaptops(int price)
        {
            HashSet<Laptop> laptops = Database.Laptops.Where(l => { return l.Price <= price; }).ToHashSet();

            return View("ListOfLaptops", laptops);
        }

        //getti all laptops in types new, refurbished,rental
        public IActionResult InType(string type)
        {

            List<string> laptoptype = Enum.GetNames(typeof(Laptoptype)).ToList();


            if (laptoptype.Contains(type, StringComparer.OrdinalIgnoreCase))
            {
                HashSet<Laptop> laptopsinType = Database.Laptops.Where(m =>
                {
                    return m.Type.ToString().Equals(type, StringComparison.OrdinalIgnoreCase);
                }).ToHashSet();

                ViewBag.MovieCount = laptopsinType.Count;
                ViewBag.PageTitle = $"Laptops in {type}";
                return View("ListOfLaptops", laptopsinType);
            }
            else
            {
                return NotFound();
            }


        }

        //laptops in budget
        public IActionResult InBudget()
        {
            GetInBudget budgetlaptops = new GetInBudget(Database.Laptops);
            return View(budgetlaptops);
        }

        [HttpPost]
        public IActionResult InBudget([Bind("LaptopPrice")] GetInBudget budgetlaptops)
        {
            try
            {
                int price = budgetlaptops.LaptopPrice;
                Laptop laptop = Database.Laptops.First(m => m.Price >= price);


                return RedirectToAction("InBudget" );
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }


        //comapring two laptops
        public IActionResult CompareLaptops()
        {
            CompareLaptops cl = new CompareLaptops(Database.Laptops, Database.Laptops1);
            return View(cl);
        }


        [HttpPost]
        public IActionResult CompareLaptops([Bind("LaptopID1", "LaptopID2")] CompareLaptops cl)
        {
            try
            {

                Laptop laptop = Database.Laptops.First(l => l.Id == Int32.Parse(cl.Id));
                Laptop laptop1 = Database.Laptops.First(l => l.Id == Int32.Parse(cl.Id2));


                return RedirectToAction("display", "LaptopAndBrand", new { LaptopID1 = laptop.Id, LaptopID2 = laptop1.Id });
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        public IActionResult display(int LaptopID1, int LaptopID2)
        {
            List<Laptop> comparedlaptops = new List<Laptop>();

            Laptop laptop1 = Database.Laptops.First(m => { return m.Id == LaptopID1; });

            Laptop laptop2 = Database.Laptops.First(m => { return m.Id == LaptopID2; });

            comparedlaptops.Add(laptop1);
            comparedlaptops.Add(laptop2);

                return View("display", comparedlaptops);

        }


        //getting all laptops by brands
     public IActionResult GetAllLaptops()
        {
            return View( "GetAllLaptops", Database.Brands);
        }


    }

}
