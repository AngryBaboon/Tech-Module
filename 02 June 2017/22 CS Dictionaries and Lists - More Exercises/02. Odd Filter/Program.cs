using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            input.RemoveAll(i => i % 2 == 1);

            var average = input.Average();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] > average) input[i]++;
                else if (input[i] <= average) input[i]--;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
