using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            var index = 0;
            var count = 1;
            var longestCount = 1;
            var longestSequence = 0;

            while (index < nums.Count - 1)
            {
                if (nums[index] == nums[index + 1])
                {
                    count++;

                    if (count > longestCount)
                    {
                        longestCount = count;
                        longestSequence = nums[index];
                    }
                }
                else
                    count = 1;

                index++;

                if (longestCount == 1)
                {
                    longestSequence = nums[0];
                }
            }
            for (int i = 0; i < longestCount; i++)
            {
                Console.Write(longestSequence + " ");
            }
            Console.WriteLine();
        }
    }
}
