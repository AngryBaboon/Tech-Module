using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var figureType = Console.ReadLine().ToLower();

            FigureArea(figureType);
        }

        static void FigureArea(string figureType)
        {
            var a = 0d;
            var b = 0d;
            var h = 0d;
            var r = 0d;

            switch (figureType)
            {
                case "triangle":
                    b = double.Parse(Console.ReadLine());
                    h = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Round(b * h / 2, 2)); break;
                case "square":
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Round(Math.Pow(a, 2), 2)); break;
                case "rectangle":
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Round(a * b, 2)); break;
                case "circle":
                    r = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Round(Math.Pow(r, 2) * Math.PI, 2)); break;
                default: break;
            }
        }
    }
}
