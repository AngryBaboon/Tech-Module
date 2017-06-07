using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(a * 2 + b * 2);
            Console.WriteLine(a * b);
            Console.WriteLine(Math.Sqrt(a * a + b * b));
        }
    }
}