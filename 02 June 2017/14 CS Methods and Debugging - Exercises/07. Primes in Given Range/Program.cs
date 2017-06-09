using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            var startNum = long.Parse(Console.ReadLine());
            var endNum = long.Parse(Console.ReadLine());

            WritePrime(startNum, endNum);
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

        static void WritePrime(long startNum, long endNum)
        {
            string writePrime = String.Empty;

            for (long num = startNum; num <= endNum; num++)
            {
                if (IsPrime(num) == true)
                    writePrime += num + ", ";
            }
            Console.WriteLine(writePrime.TrimEnd(',', ' '));
        }
    }
}
