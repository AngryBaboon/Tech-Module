using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var reversedNums = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                var num = nums[i];
                var reversedNum = 0;

                while (num > 0)
                {
                    reversedNum = reversedNum * 10 + num % 10;
                    num /= 10;
                }

                reversedNums.Add(reversedNum);
            }
            Console.WriteLine(reversedNums.Sum());
        }
    }
}
