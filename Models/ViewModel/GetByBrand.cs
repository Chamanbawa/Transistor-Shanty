using Microsoft.AspNetCore.Mvc;
using Transistor_Shanty.Data;

namespace Transistor_Shanty.Models.ViewModel
{
    public class GetByBrand {

        public List<Brand> brands { get; } = new List<Brand>();

        public void AddingLaptop()
        {

            foreach (Brand b in Database.Brands)
            {
                brands.Add(b);
            }
        }



    }
}
