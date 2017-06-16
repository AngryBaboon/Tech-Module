using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var index = 0;
            var sum = 0;

            while (true)
            {
                var tempIndex = index;

                sum += arr[index];
                index += arr[index];

                if (index > arr.Length - 1)
                {
                    index = tempIndex - arr[tempIndex];

                    if (index < 0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
