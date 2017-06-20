using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var numsTaken = new List<int>();

            for (int i = 0; i < arr[0]; i++)
            {
                numsTaken.Add(nums[i]);
            }

            for (int i = 0; i < arr[1]; i++)
            {
                numsTaken.RemoveAt(0);
            }

            if (numsTaken.Contains(arr[2]))
                Console.WriteLine("YES!");
            else
                Console.WriteLine("NO!");
        }
    }
}
