using Microsoft.AspNetCore.Mvc;
using System.Data;
using Transistor_Shanty.Models;

namespace Transistor_Shanty.Data
{
    public static class Database
    {
        // === STORAGE
        public static HashSet<Laptop> Laptops = new HashSet<Laptop>();
        public static HashSet<Brand> Brands = new HashSet<Brand>();


        // === METHODS
        private static int _idCount = 0;
        public static int GetIdCount()
        {
            _idCount++;
            return _idCount;
        }


        private static void _seedMethod()
        {
            //Brands
            Brand dell = new Brand("Dell");
            Brand hp = new Brand("Hp");
            Brand msi = new Brand("MSI");

            Brands.Add(dell);
            Brands.Add(hp);
            Brands.Add(msi);


            //Lapotps
            Laptop laptop1 = new Laptop(dell, "XPS", 500, new DateTime(2017, 1, 1), 3, "New");

            Laptop laptop2 = new Laptop(dell, "G3", 600, new DateTime(2018, 1, 1), 2, "Refurbished ");

            Laptop laptop3 = new Laptop(dell, "Inspiron", 800, new DateTime(2019, 1, 1), 1, "Rental");

            Laptop laptop4 = new Laptop(dell, "Inspiron", 850, new DateTime(2019, 1, 1), 1, "New");

            Laptop laptop5 = new Laptop(dell, "Inspiron", 2500, new DateTime(2019, 1, 1), 1, "Rental");

            Laptop laptop6 = new Laptop(hp, "Essential", 900, new DateTime(2017, 1, 1), 1, "New");

            Laptop laptop7 = new Laptop(hp, "Pavilion", 1000, new DateTime(2018, 1, 1), 1, "Refurbished");

            Laptop laptop8 = new Laptop(hp, "Spectre", 5000, new DateTime(2019, 1, 1), 1, "Rental");

            Laptop laptop9 = new Laptop(hp, "Spectre", 900, new DateTime(2019, 1, 1), 1, "New");

            Laptop laptop10 = new Laptop(hp, "Spectre", 1000, new DateTime(2019, 1, 1), 1, "Rental");

            Laptop laptop11 = new Laptop(msi, "Raider", 1200, new DateTime(2019, 1, 1), 1, "New");

            Laptop laptop12 = new Laptop(msi, "Stealth ", 1300, new DateTime(2020, 1, 1), 1, "Refurbished");

            Laptop laptop13 = new Laptop(msi, "Prestige ", 1400, new DateTime(2021, 1, 1), 1, "Rental");

            Laptop laptop14 = new Laptop(msi, "Prestige ", 1500, new DateTime(2021, 1, 1), 1, "New");

            Laptop laptop15 = new Laptop(msi, "Prestige ", 1600, new DateTime(2021, 1, 1), 1, "Rental");

            Laptops.Add(laptop1);
            Laptops.Add(laptop2);
            Laptops.Add(laptop3);
            Laptops.Add(laptop4);
            Laptops.Add(laptop5);
            Laptops.Add(laptop6);
            Laptops.Add(laptop7);
            Laptops.Add(laptop8);
            Laptops.Add(laptop9);
            Laptops.Add(laptop10);
            Laptops.Add(laptop11);
            Laptops.Add(laptop12);
            Laptops.Add(laptop13);
            Laptops.Add(laptop14);
            Laptops.Add(laptop15);


            dell.AddLaptop(laptop1);
            dell.AddLaptop(laptop2);
            dell.AddLaptop(laptop3);
            dell.AddLaptop(laptop4);
            dell.AddLaptop(laptop5);
            hp.AddLaptop(laptop6);
            hp.AddLaptop(laptop7);
            hp.AddLaptop(laptop8);
            hp.AddLaptop(laptop9);
            hp.AddLaptop(laptop10);
            msi.AddLaptop(laptop11);
            msi.AddLaptop(laptop12);
            msi.AddLaptop(laptop13);
            msi.AddLaptop(laptop14);
            msi.AddLaptop(laptop15);




        }


        // === CONSTRUCTOR
        static Database()
        {
            _seedMethod();
        }
    }
}
