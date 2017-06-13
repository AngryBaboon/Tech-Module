using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Fib(n);
        }

        static void Fib(int n)
        {
            int fib = 1;
            int first = 0;
            int second = 1;

            for (int i = 0; i <= n + 1; i++)
            {
                if (i <= 1)
                    fib = 1;
                else
                {
                    fib = first + second;
                    first = second;
                    second = fib;
                }
            }
            Console.WriteLine(fib);
        }
    }
}
