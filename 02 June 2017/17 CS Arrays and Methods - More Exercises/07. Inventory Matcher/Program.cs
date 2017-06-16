using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            var quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            while (true)
            {
                string products = Console.ReadLine();

                if (products == "done") break;

                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == products)
                    {
                        Console.WriteLine($"{products} costs: {prices[i]}; Available quantity: {quantities[i]}");
                    }
                }
            }
        }
    }
}
