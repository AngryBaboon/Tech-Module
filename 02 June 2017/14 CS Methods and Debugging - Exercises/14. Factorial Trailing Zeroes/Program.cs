using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            BigInteger factorial = ReturnFactorial(n);

            Console.WriteLine(ReturnZeroes(factorial));
        }

        static BigInteger ReturnFactorial(int n)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        static int ReturnZeroes(BigInteger factorial)
        {
            int zeroCount = 0;

            BigInteger lastDigit = 0;

            while (lastDigit == 0)
            {
                lastDigit = factorial % 10;

                if (lastDigit == 0)
                    zeroCount++;

                factorial /= 10;
            }

            return zeroCount;
        }
    }
}