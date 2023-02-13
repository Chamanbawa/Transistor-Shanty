using Microsoft.AspNetCore.Mvc;
using Transistor_Shanty.Data;
using static Transistor_Shanty.Data.Database;

namespace Transistor_Shanty.Models
{
    public class Laptop
    {
        private int _id = 0;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _model;
        public string ModelName
        {
            get
            {
                return _model;
            }
            set { _model = value; }
        }

        private Brand _brand;
        public Brand Brand
        {
            get
            {
                return _brand;
            }
            set { _brand = value; }
        }
        private int _price;
        public int Price
        {
            get
            {
                return _price;
            }
            set { _price = value; }
        }

        private DateTime _year;
        public DateTime Year
        {
            get { return _year; }
            set { _year = value; }

        }
        private int _quantity;
      

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }


        public Laptoptype Type { get; set; }



        public Laptop(Brand brand,string model, int price, DateTime year, int quantity, Laptoptype type)
        {
            _id++;
            Brand = brand;
            ModelName = model;
            Price = price;
            Year = year;
            Quantity = quantity;
            Type = type;


        }

      
    }
}
