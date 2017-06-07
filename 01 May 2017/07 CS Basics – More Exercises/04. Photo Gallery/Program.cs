using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());
            var size = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{number:D4}.jpg");

            if (year < 1000)
                Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/20{year:D2} {hour:D2}:{min:D2}");
            else
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year:D4} {hour:D2}:{min:D2}");

            if (size < 1000)
                Console.WriteLine($"Size: {size}B");
            else if (size > 100000 && size < 1000000)
                Console.WriteLine($"Size: {size/1000}KB");
            else if (size > 1000000)
                Console.WriteLine($"Size: {size / 1000000}MB");

            Console.Write($"Resolution: {width}x{height} ");
            if (width > height)
                Console.WriteLine("(landscape)");
            else if (width < height)
                Console.WriteLine("(portrait)");
            else if (width == height)
                Console.WriteLine("(square)");
        }
    }
}
