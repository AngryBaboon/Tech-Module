using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var k = arr.Length / 4;

            int[] Row1 = new int[k * 2];
            int[] Row2 = new int[k * 2];

            var index = 0;

            for (int i = k - 1; i >= 0; i--)
            {
                Row1[index] = arr[i];
                index++;
            }

            for (int i = arr.Length - 1; i >= k * 3; i--)
            {
                Row1[index] = arr[i];
                index++;
            }

            index = k;

            for (int i = 0; i < Row2.Length; i++)
            {
                Row2[i] = arr[index];
                index++;
            }

            int[] sumArr = new int[k * 2];

            for (int i = 0; i < Row1.Length; i++)
            {
                sumArr[i] = Row1[i] + Row2[i];
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
