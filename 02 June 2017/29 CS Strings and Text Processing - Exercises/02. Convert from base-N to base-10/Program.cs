using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var baseN = int.Parse(input[0]);
            var baseNum = input[1].Reverse().ToArray();

            BigInteger num = 0;

            for (int i = 0; i < baseNum.Count(); i++)
            {
                num += int.Parse(baseNum[i].ToString()) * BigInteger.Pow(baseN, i);
            }
            Console.WriteLine(num);
        }
    }
}