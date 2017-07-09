using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var initialIndexes = Regex.Split(Console.ReadLine(), @"\s+")
                .Select(int.Parse)
                .Where(a => a >= 0 && a < fieldSize)
                .ToArray();

            var arr = new int[fieldSize];

            foreach (var index in initialIndexes)
            {
                arr[index] = 1;
            }

            while (true)
            {
                var input = Console.ReadLine().ToLower();

                if (input == "end") break;

                var command = Regex.Split(input, @"\s+");

                var index = int.Parse(command[0]);
                var direction = command[1];
                var flyLength = int.Parse(command[2]);

                if (index >= 0 && index < fieldSize && arr[index] == 1)
                {
                    Move(index, direction, flyLength, arr, fieldSize);
                }
            }

            var output = string.Empty;
            foreach (var cell in arr)
            {
                if (cell < fieldSize)
                {
                    output += $"{cell} ";
                }
            }
            Console.WriteLine(output.TrimEnd(' '));
        }

        private static void Move(int index, string direction, int flyLength, int[] arr, int fieldSize)
        {
            if (direction == "left")
            {
                flyLength = -flyLength;
            }

            arr[index] = 0;

            var nextIndex = index + flyLength;

            if (nextIndex < fieldSize && nextIndex >= 0)
            {
                if (arr[nextIndex] == 0)
                    arr[nextIndex] = 1;

                else if (arr[nextIndex] == 1)
                {
                    var totalFlyLength = index + (flyLength * 2);

                    while (totalFlyLength < fieldSize && totalFlyLength >= 0)
                    {
                        if (arr[totalFlyLength] == 0)
                        {
                            arr[totalFlyLength] = 1;
                            break;
                        }

                        totalFlyLength += index + (flyLength * 2);
                    }
                }
            }
        }
    }
}