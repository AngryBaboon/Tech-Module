using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var meters = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var seconds = int.Parse(Console.ReadLine());

            var ms = meters / ((hours * 60f + minutes) * 60f + seconds);
            var kmh = meters/1000f / (((hours * 60f + minutes) * 60f + seconds) / 3600f);
            var mph = meters/1609f / (((hours * 60f + minutes) * 60f + seconds) / 3600f);

            Console.WriteLine($"{ms}");
            Console.WriteLine($"{kmh}");
            Console.WriteLine($"{mph}");
        }
    }
}