using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            var prof = Console.ReadLine();
            switch (prof)
            {
                case "Athlete": Console.WriteLine("Water");break;
                case "Businessman": Console.WriteLine("Coffee"); break;
                case "Businesswoman": Console.WriteLine("Coffee"); break;
                case "SoftUni Student": Console.WriteLine("Beer"); break;
                default: Console.WriteLine("Tea"); break;
            }
        }
    }
}
