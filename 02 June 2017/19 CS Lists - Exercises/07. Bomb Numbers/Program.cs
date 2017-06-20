using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = bomb[0];
            int power = bomb[1];

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == number)
                {
                    nums[i] = 0;
                    for (int j = 1; j <= power; j++)
                    {
                        if (i + j >= nums.Count)
                        {
                            break;
                        }
                        else
                        {
                            nums[i + j] = 0; ;
                        }
                    }

                    for (int k = 1; k <= power; k++)
                    {
                        if (i - k < 0)
                        {
                            break;
                        }
                        else
                        {
                            nums[i - k] = 0;
                        }
                    }
                }
            }
            int result = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                result += nums[i];
            }
            Console.WriteLine(result);
        }
    }
}
