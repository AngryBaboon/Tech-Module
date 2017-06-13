using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            PrintClosestPointsToCenter(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void PrintClosestPointsToCenter(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double line1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)) + Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            double line2 = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2)) + Math.Sqrt(Math.Pow(x4, 2) + Math.Pow(y4, 2));

            if (line1 >= line2)
            {
                bool first = true;

                if (Math.Sqrt(x1 * x1 + y1 * y1) > Math.Sqrt(x2 * x2 + y2 * y2))
                    first = false;

                if (first)
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                else
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                bool first = true;

                if (Math.Sqrt(x3 * x3 + y3 * y3) > Math.Sqrt(x4 * x4 + y4 * y4))
                    first = false;

                if (first)
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                else
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
            }
        }
    }
}
