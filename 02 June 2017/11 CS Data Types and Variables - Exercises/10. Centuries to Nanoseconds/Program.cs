using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var centuries = int.Parse(Console.ReadLine());

            var years = centuries * 100;
            var days = Math.Floor(years * 365.2422M);
            var hours = days * 24;
            var minutes = hours * 60;
            var seconds = minutes * 60;
            var milliseconds = seconds * 1000;
            var microseconds = milliseconds * 1000;
            var nanoseconds = microseconds * 1000;

            Console.Write($"{centuries} centuries = ");
            Console.Write($"{years} years = ");
            Console.Write($"{days:F0} days = ");
            Console.Write($"{hours:F0} hours = ");
            Console.Write($"{minutes:F0} minutes = ");
            Console.Write($"{seconds:F0} seconds = ");
            Console.Write($"{milliseconds:F0} milliseconds = ");
            Console.Write($"{microseconds:F0} microseconds = ");
            Console.Write($"{nanoseconds:F0} nanoseconds");
            Console.WriteLine();
        }
    }
}
