using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToList();

            int index = 0;
            int element = 0;

            while (true)
            {
                var command = Console.ReadLine().Split();

                if (command[0] == "print")
                {
                    Console.WriteLine("[" + string.Join(", ", arr) + "]");
                    break;
                }

                switch (command[0])
                {
                    case "add":
                        index = int.Parse(command[1]);
                        element = int.Parse(command[2]);
                        arr.Insert(index, element);
                        break;

                    case "addMany":
                        index = int.Parse(command[1]);
                        for (int i = command.Length - 1; i >= 2; i--)
                        {
                            element = int.Parse(command[i]);
                            arr.Insert(index, element);
                        }
                        break;

                    case "contains":
                        element = int.Parse(command[1]);
                        if (arr.Contains(element))
                        {
                            index = 0;
                            while (arr[index] != element)
                            {
                                index++;
                            }
                            Console.WriteLine(index);
                        }
                        else Console.WriteLine(-1);
                        break;

                    case "remove":
                        index = int.Parse(command[1]);
                        arr.RemoveAt(index);
                        break;

                    case "shift":
                        var position = int.Parse(command[1]);
                        for (int i = 0; i < position; i++)
                        {
                            arr.Add(arr[0]);
                            arr.RemoveRange(0, 1);
                        }
                        break;

                    case "sumPairs":
                        index = 0;
                        if (arr.Count % 2 == 0)
                        {
                            while (index < arr.Count)
                            {
                                arr[index] += arr[index + 1];
                                arr.RemoveAt(index + 1);
                                index++;
                            }
                        }
                        else
                        {
                            while (index < arr.Count - 1)
                            {
                                arr[index] += arr[index + 1];
                                arr.RemoveAt(index + 1);
                                index++;
                            }
                        }
                        break;

                    default: break;
                }
            }
        }
    }
}
