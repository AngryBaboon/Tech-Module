using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            PringInReverse(num);
        }

        static void PringInReverse(string num)
        {
            var length = num.Length;
            var numReversed = String.Empty;

            while (length > 0)
            {
                numReversed += num.Last();
                num = num.Remove(num.Length - 1);
                length--;
            }
            Console.WriteLine(numReversed);
        }
    }
}