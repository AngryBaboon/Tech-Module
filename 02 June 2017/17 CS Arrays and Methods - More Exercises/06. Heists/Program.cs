using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var jewelPrice = price[0];
            var goldPrice = price[1];

            var earnings = 0;
            var expenses = 0;

            string[] loot = new string[2];

            while (true)
            {
                loot = Console.ReadLine().Split();

                if (loot[0] == "Jail") break;

                char[] chrArr = loot[0].ToCharArray();

                for (int i = 0; i < loot[0].Length; i++)
                {
                    if (chrArr[i] == '%')
                    {
                        earnings += jewelPrice;
                    }
                    if (chrArr[i] == '$')
                    {
                        earnings += goldPrice;
                    }
                }
                expenses -= int.Parse(loot[1]);
            }
            if (earnings + expenses >= 0)
                Console.WriteLine($"Heists will continue. Total earnings: {earnings + expenses}.");
            else
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(earnings + expenses)}.");
        }
    }
}
