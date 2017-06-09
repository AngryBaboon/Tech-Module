using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(num));
        }

        static bool IsPrime(long num)
        {
            if (num == 1) return false;
            if (num == 2) return true;

            if (num % 2 == 0) return false;

            for (long i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }

            return true;
        }
    }
}
