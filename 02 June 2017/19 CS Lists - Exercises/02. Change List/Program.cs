using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                var command = Console.ReadLine().Split();

                var action = command[0];

                if (action == "Odd")
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] % 2 == 1)
                            Console.Write(nums[i] + " ");
                    }
                    break;
                }
                else if (action == "Even")
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] % 2 == 0)
                            Console.Write(nums[i] + " ");
                    }
                    break;
                }


                else if (action == "Delete")
                {
                    var numToRemove = int.Parse(command[1]);

                    for (int i = 0; i < nums.Count; i++)
                    {
                        nums.Remove(numToRemove);
                    }
                }
                else if (action == "Insert")
                {
                    var numToInsert = int.Parse(command[1]);
                    var position = int.Parse(command[2]);

                    nums.Insert(position, numToInsert);
                }
            }
            Console.WriteLine();
        }
    }
}
