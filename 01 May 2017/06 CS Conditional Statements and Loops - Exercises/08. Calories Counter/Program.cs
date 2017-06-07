using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cal = 0;
            for (int i = 1; i <= n; i++)
            {
                var ingredient = Console.ReadLine().ToLower();
                if (ingredient == "cheese")
                    cal += 500;
                if (ingredient == "tomato sauce")
                    cal += 150;
                if (ingredient == "salami")
                    cal += 600;
                if (ingredient == "pepper")
                    cal += 50;
            }
            Console.WriteLine($"Total calories: {cal}");
        }
    }
}
