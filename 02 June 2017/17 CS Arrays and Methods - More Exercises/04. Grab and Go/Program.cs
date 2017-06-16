using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());
            long sum = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == n)
                {
                    i--;
                    while (i >= 0)
                    {
                        sum += arr[i];
                        i--;
                    }
                    Console.WriteLine(sum);
                    break;
                }
                else if (arr[i] != n && i == 0)
                    Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
