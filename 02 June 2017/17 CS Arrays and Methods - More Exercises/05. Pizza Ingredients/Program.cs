using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredient = Console.ReadLine().Split();
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            var ingredientsUsed = string.Empty;

            for (int i = 0; i < ingredient.Length; i++)
            {
                if (ingredient[i].Length == n)
                {
                    Console.WriteLine($"Adding {ingredient[i]}.");
                    ingredientsUsed += ingredient[i] + ", ";
                    count++;
                    if (count == 10) break;
                }
            }
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine("The ingredients are: {0}.", ingredientsUsed.TrimEnd(',', ' '));
        }
    }
}
