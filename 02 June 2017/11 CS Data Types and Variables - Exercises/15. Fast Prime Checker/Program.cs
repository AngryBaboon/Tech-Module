using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 2; num <= n; num++)
            {
                bool prime = true;

                for (int i2 = 2; i2 <= Math.Sqrt(num); i2++)
                {
                    if (num % i2 == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{num} -> {prime}");
            }
        }
    }
}
