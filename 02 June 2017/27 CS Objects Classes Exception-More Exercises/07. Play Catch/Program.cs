using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Play_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var exceptionCount = 0;

            while (exceptionCount < 3)
            {
                var input = Console.ReadLine().Split();

                var command = input[0];

                if (command == "Replace")
                {
                    try
                    {
                        var index = int.Parse(input[1]);
                        var element = int.Parse(input[2]);

                        arr[index] = element;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        exceptionCount++;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("The index does not exist!");
                        exceptionCount++;
                    }
                }
                else if (command == "Print")
                {
                    try
                    {
                        var startIndex = int.Parse(input[1]);
                        var endIndex = int.Parse(input[2]);

                        var s = string.Empty;

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            s += $"{arr[i]}, ";
                        }

                        Console.WriteLine(s.TrimEnd(' ', ','));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        exceptionCount++;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("The index does not exist!");
                        exceptionCount++;
                    }
                }
                else if (command == "Show")
                {
                    try
                    {
                        var index = int.Parse(input[1]);

                        Console.WriteLine(arr[index]);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        exceptionCount++;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("The index does not exist!");
                        exceptionCount++;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
