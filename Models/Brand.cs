using Microsoft.AspNetCore.Mvc;
using System.Data;

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
        public Laptop Laptop { get; set; }


        public List<Laptop> Laptops = new List<Laptop>();

        public void AddLaptop(Laptop laptop)
        {
            Laptops.Add(laptop);
        }
      public List<Laptop> GetLaptops()
        {
            return Laptops.ToList();
        }


        public Brand(string name)
        {

            _id++;
            Name = name;
        }
        public Brand()
        {

        }


    }
}
