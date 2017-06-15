using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            PrintMin(arr);
            PrintMax(arr);
            PrintSum(arr);
            PrintAverage(arr);
        }

        private static void PrintMin(int[] arr)
        {
            var min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                min = Math.Min(arr[i], min);
            }

            Console.WriteLine($"Min = {min}");
        }

        private static void PrintMax(int[] arr)
        {
            var max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                max = Math.Max(arr[i], max);
            }

            Console.WriteLine($"Max = {max}");
        }

        private static void PrintSum(int[] arr)
        {
            var sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine($"Sum = {sum}");
        }

        private static void PrintAverage(int[] arr)
        {
            double average = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                average += arr[i];
            }

            average /= arr.Length;

            Console.WriteLine($"Average = {average}");
        }
    }
}
