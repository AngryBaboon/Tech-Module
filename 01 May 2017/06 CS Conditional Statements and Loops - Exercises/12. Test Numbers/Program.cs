using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());
            int m = 0;
            int comb = 0;
            int sum = 0;


            for (int i = 1; i <= 1000000; i++)
            {

                    if (m == M)
                    {
                        N--;
                        m = 0;
                    }

                    m++;

                    sum += (N * m) * 3;

                    comb++;

                if (sum >= max || (N == 1 && m == M))
                {
                    Console.WriteLine($"{comb} combinations");

                    if (sum >= max)
                        Console.WriteLine($"Sum: {sum} >= {max}");
                    else
                        Console.WriteLine($"Sum: {sum}");
                    break;
                }
            }
        }
    }
}
