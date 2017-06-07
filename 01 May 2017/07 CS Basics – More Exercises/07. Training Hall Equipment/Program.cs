using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            double sub = 0;
            for (int i = 1; i <= n; i++)
            {
                var name = Console.ReadLine();
                var price = double.Parse(Console.ReadLine());
                var count = int.Parse(Console.ReadLine());
                if (count > 1)
                    Console.WriteLine($"Adding {count} {name}s to cart.");
                else
                    Console.WriteLine($"Adding {count} {name} to cart.");
                sub += price * count;
            }
            Console.WriteLine($"Subtotal: ${sub:F2}");
            if (budget - sub > 0)
                Console.WriteLine($"Money left: ${budget - sub:F2}");
            else
                Console.WriteLine($"Not enough. We need ${Math.Abs(budget - sub):F2} more.");
        }
    }
}