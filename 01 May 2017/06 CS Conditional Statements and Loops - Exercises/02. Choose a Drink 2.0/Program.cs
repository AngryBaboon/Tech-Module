using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var prof = Console.ReadLine();
            var quan = int.Parse(Console.ReadLine());
            switch (prof)
            {
                case "Athlete": Console.WriteLine($"The {prof} has to pay {quan * 0.70:F2}."); break;
                case "Businessman": Console.WriteLine($"The {prof} has to pay {quan * 1.00:F2}."); break;
                case "Businesswoman": Console.WriteLine($"The {prof} has to pay {quan * 1.00:F2}."); break;
                case "SoftUni Student": Console.WriteLine($"The {prof} has to pay {quan * 1.70:F2}."); break;
                default: Console.WriteLine($"The {prof} has to pay {quan * 1.20:F2}."); break;
            }
        }
    }
}