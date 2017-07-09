using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            var cash = double.Parse(Console.ReadLine());
            var guests = double.Parse(Console.ReadLine());
            var bananaPrice = double.Parse(Console.ReadLine());
            var eggPrice = double.Parse(Console.ReadLine());
            var berriesPrice = double.Parse(Console.ReadLine());

            var portions = Math.Ceiling(guests / 6);
            var cost = (bananaPrice * 2 + eggPrice * 4 + berriesPrice * 0.2) * portions;

            if (cost <= cash)
                Console.WriteLine($"Ivancho has enough money - it would cost {cost:F2}lv.");
            else
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {Math.Abs(cash - cost):F2}lv more.");
        }
    }
}
