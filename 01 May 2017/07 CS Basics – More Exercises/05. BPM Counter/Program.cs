using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var BPM = int.Parse(Console.ReadLine());
            var nBeats = int.Parse(Console.ReadLine());

            Console.Write($"{Math.Round((nBeats / 4.0),1)} bars - ");
            Console.WriteLine("");
        }
    }
}
