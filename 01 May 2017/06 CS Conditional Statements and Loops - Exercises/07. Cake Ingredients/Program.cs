using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            int n = 1;
            Console.WriteLine($"Adding ingredient {a}.");
            while (a != "Bake!")
            {
                a = Console.ReadLine();
                if (a == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {n} ingredients.");
                }
                else
                {
                    n++;
                    Console.WriteLine($"Adding ingredient {a}.");
                }
            }
        }
    }
}
