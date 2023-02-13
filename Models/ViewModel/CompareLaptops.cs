using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Transistor_Shanty.Models.ViewModel
{
    public class CompareLaptops
    {
        public List<SelectListItem> Laptop { get; } = new List<SelectListItem>();
        public List<SelectListItem> Laptop1 { get; } = new List<SelectListItem>();

        public string Id { get; set; }
        public string Id2 { get; set; }


        public CompareLaptops(HashSet<Laptop> laptop, HashSet<Laptop> laptop1)
        {

            foreach (Laptop l in laptop)
            {
                Laptop.Add(new SelectListItem(l.ModelName, l.Id.ToString()));
            }
            foreach (Laptop l in laptop1)
            {
                Laptop1.Add(new SelectListItem(l.ModelName, l.Id.ToString()));

            }

        }


        public CompareLaptops()
        {

        }
    }

}
