using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var baseN = int.Parse(input[0]);
            var num = BigInteger.Parse(input[1]);
            var list = new List<int>();

            while (num > 0)
            {
                var rem = num % baseN;
                num = num / baseN;

                list.Add((int)rem);
            }
            list.Reverse();

            Console.WriteLine(string.Join("", list));
        }
    }
}
