using Microsoft.AspNetCore.Mvc;

namespace Transistor_Shanty.Models
{
    public class Brand
    {
        private int _id = 0;
        public int Id
        {
            get { return _id; }
            set{ _id = value; }
        }
  
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }
        private HashSet<Laptop> _laptops = new HashSet<Laptop>();

        public void AddLaptop(Laptop laptop)
        {
            _laptops.Add(laptop);
        }


        public Brand(string name)
        {

            _id++;
            Name = name;
        }


    }
}
