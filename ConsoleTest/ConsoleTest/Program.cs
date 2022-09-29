using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FindRestaurant a = new FindRestaurant();
            string[] b = { "Shogun", "Tapioca Express", "Burger King", "KFC" };
            string[] c = { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" };
            Console.WriteLine(a.findRestaurant(b,c));
            Console.ReadKey();
        }
    }


}
