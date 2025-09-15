using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Computing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double TotalCost;

            Sleepers sandugo = new Sleepers();
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("----Welcome to Sandugo Online Shop----");
                Console.Write("Enter Price for Sandugo:");
                sandugo.Price = Convert.ToDouble(Console.ReadLine());
                TotalCost = sandugo.Price * sandugo.Discount;

                 sandugo.DisplayInfo();
                Console.WriteLine($"Total Cost after discount: {TotalCost}");

            }

           

            
        }
    }
}
