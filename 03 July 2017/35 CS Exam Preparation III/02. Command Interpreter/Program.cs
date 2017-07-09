using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = Regex.Split(Console.ReadLine(), @"\s+").ToList();

            while (true)
            {
                var input = Regex.Split(Console.ReadLine().ToLower(), @"\s+").ToArray();
                if (input[0] == "end") break;

                var command = input[0];
                var start = 0;
                var count = 0;

                if (command == "reverse" || command == "sort")
                {
                    start = int.Parse(input[2]);
                    count = int.Parse(input[4]);
                }
                else if (command == "rollleft" || command == "rollright")
                {
                    count = int.Parse(input[1]);
                }

                if (start > collection.Count - 1 || start < 0 || count < 0)
                {
                    Console.WriteLine("Invalid input parameters.");
                    continue;
                }

                switch (command)
                {
                    case "reverse":
                        if (start + count - 1 < collection.Count)
                        {
                            var reverse = collection.GetRange(start, count);
                            reverse.Reverse();
                            collection.RemoveRange(start, count);
                            collection.InsertRange(start, reverse);
                        }
                        else
                            Console.WriteLine("Invalid input parameters.");
                        break;
                    case "sort":
                        if (start + count - 1 < collection.Count)
                        {
                            var sort = collection.GetRange(start, count);
                            sort.Sort();
                            collection.RemoveRange(start, count);
                            collection.InsertRange(start, sort);
                        }
                        else
                            Console.WriteLine("Invalid input parameters.");
                        break;
                    case "rollleft": //po hamalski (timeout)
                        for (int i = 0; i < count; i++)
                        {
                            var element = collection[0];
                            collection.RemoveAt(0);
                            collection.Add(element);
                        }
                        break;
                    case "rollright": //po hamalski (timeout)
                        for (int i = 0; i < count; i++)
                        {
                            var element = collection.Last();
                            collection.RemoveAt(collection.Count - 1);
                            collection.Insert(0, element);
                        }
                        break;
                    default: break;
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", collection));
        }
    }
}
