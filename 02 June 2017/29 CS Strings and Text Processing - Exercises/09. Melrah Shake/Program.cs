using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var key = Console.ReadLine();

            while (true)
            {
                var leftIndex = input.IndexOf(key);
                var rightIndex = input.LastIndexOf(key);

                var leftIndexExist = leftIndex != -1;
                var rightIndexExist = rightIndex != -1;

                var leftAndRightEqual = leftIndex == rightIndex;

                var keyIsEmpty = key != string.Empty;

                if (leftIndexExist && rightIndexExist && !leftAndRightEqual && !keyIsEmpty)
                {
                    input = input.Remove(rightIndex, key.Length);
                    input = input.Remove(leftIndex, key.Length);

                    Console.WriteLine("Shake it.");
                    key = key.Remove(key.Length / 2, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }
            }
        }
    }
}
