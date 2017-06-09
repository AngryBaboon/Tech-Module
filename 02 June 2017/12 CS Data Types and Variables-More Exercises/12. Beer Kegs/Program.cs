using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var model = String.Empty;
            var r = 0d;
            var h = 0;

            var tempVolume = 0d;

            var biggestKeg = String.Empty;

            for (int i = 0; i < n; i++)
            {
                model = Console.ReadLine();
                r = double.Parse(Console.ReadLine());
                h = int.Parse(Console.ReadLine());

                var volume = Math.PI * Math.Pow(r, 2) * h;

                if (volume > tempVolume)
                {
                    tempVolume = volume;
                    biggestKeg = model;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}