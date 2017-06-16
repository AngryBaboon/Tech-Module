using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Upgraded_Matcher
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
                var input = Console.ReadLine().Split();

                if (input[0] == "done") break;

                var inputName = input[0];
                long inputQuantity = long.Parse(input[1]);


                int index = Array.IndexOf(names, inputName);

                long goodsStock = index < quantities.Length ? quantities[index] : 0;


                if (goodsStock >= inputQuantity)
                {
                    decimal productCost = inputQuantity * prices[index];
                    Console.WriteLine($"{inputName} x {inputQuantity} costs {productCost:F2}");
                    quantities[index] -= inputQuantity;
                }
                else
                    Console.WriteLine($"We do not have enough {inputName}");
            }
        }
    }
}