using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double MP = width * height / 1000000;
            Console.WriteLine($"{width}x{height} => {Math.Round(MP, 1)}MP ");
        }
    }
}