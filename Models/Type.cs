using Microsoft.AspNetCore.Mvc;

namespace Transistor_Shanty.Models
{
    public class Type
    {
        private Laptop _new;
        public Laptop New
        {
            get { return _new; }
            set { _new = value; }
        }
        private Laptop _refurbished;
        public Laptop Refurbished
        {
            get { return _refurbished; }
            set { _refurbished = value; }
        }
        private Laptop _rental;
        public Laptop Rental
        {
            get { return _rental; }
            set { _refurbished = value; }
        }



        public Type(Laptop laptop)
        {

            New = laptop;

        }
        //public Type(Laptop laptop)
        //{

        //    Refurbished = laptop;

        //} public Type(Laptop laptop)
        //{

        //    Rental = laptop;

        //}

    }
}
