using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Computing
{
    internal class Sleepers
    {
        public double price;
        public double discount = 0.15;
       
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }
       


        //Method
        public void DisplayInfo()
        {
            Console.WriteLine("\n----Sleepers Info----\n");
            Console.WriteLine($"Price: {Price}, Discount: {Discount}");
        }
    }

  
}
