using Microsoft.AspNetCore.Mvc.Rendering;

namespace Transistor_Shanty.Models.ViewModel
{
    public class GetInBudget
    {

        public List<Laptop> Laptops { get; } = new List<Laptop>();
        public int LaptopPrice { get; set; }
        public Laptop Laptop { get; set; }


        public List<Laptop> GetLaptops()
        {
            return Laptops.ToList();
        }

        public GetInBudget(HashSet<Laptop> laptop)
        {
         
            foreach (Laptop l in laptop)
            {
               Laptops.Add(l);
            }
        }



        public GetInBudget()
        {

        }

    }
}
