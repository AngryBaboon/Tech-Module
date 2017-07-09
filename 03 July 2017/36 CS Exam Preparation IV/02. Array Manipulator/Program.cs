using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Regex.Split(Console.ReadLine(), @"\s+").Select(int.Parse).ToList();

            while (true)
            {
                var input = Console.ReadLine().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "end") break;

                var command = input[0];

                switch (command)
                {
                    case "exchange":
                        var index = int.Parse(input[1]);
                        if (index < 0 || index >= arr.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        var count = arr.Count - 1 - index;
                        var range = arr.GetRange(index + 1, count);
                        arr.RemoveRange(index + 1, count);
                        arr.InsertRange(0, range);
                        break;
                    case "max":
                        var MaxEvenOrOdd = input[1];
                        if (MaxEvenOrOdd == "even")
                        {
                            var maxEven = arr.Where(a => a % 2 == 0).ToArray();
                            if (maxEven.Length == 0)
                            {
                                Console.WriteLine("No matches");
                                continue;
                            }
                            var indexMaxEven = arr.LastIndexOf(int.Parse(maxEven.Max().ToString()));

                            Console.WriteLine(indexMaxEven);
                        }
                        else if (MaxEvenOrOdd == "odd")
                        {
                            var maxOdd = arr.Where(a => a % 2 == 1).ToArray();
                            if (maxOdd.Length == 0)
                            {
                                Console.WriteLine("No matches");
                                continue;
                            }
                            var indexMaxOdd = arr.LastIndexOf(int.Parse(maxOdd.Max().ToString()));

                            Console.WriteLine(indexMaxOdd);
                        }
                        break;
                    case "min":
                        var MinEvenOrOdd = input[1];
                        if (MinEvenOrOdd == "even")
                        {
                            var minEven = arr.Where(a => a % 2 == 0).ToArray();
                            if (minEven.Length == 0)
                            {
                                Console.WriteLine("No matches");
                                continue;
                            }
                            var indexMinEven = arr.LastIndexOf(int.Parse(minEven.Min().ToString()));

                            Console.WriteLine(indexMinEven);
                        }
                        else if (MinEvenOrOdd == "odd")
                        {
                            var minOdd = arr.Where(a => a % 2 == 1).ToArray();
                            if (minOdd.Length == 0)
                            {
                                Console.WriteLine("No matches");
                                continue;
                            }
                            var indexMinOdd = arr.LastIndexOf(int.Parse(minOdd.Min().ToString()));

                            Console.WriteLine(indexMinOdd);
                        }
                        break;
                    case "first":
                        var firstCount = int.Parse(input[1]);
                        var firstEvenOrOdd = input[2];
                        if (firstEvenOrOdd == "even")
                        {
                            var firstEven = arr.Where(a => a % 2 == 0).ToArray();
                            if (firstEven.Length > 0)
                            {
                                if (firstCount > arr.Count)
                                {
                                    Console.WriteLine("Invalid count");
                                    continue;
                                }
                                else
                                {
                                    var evenCount = Math.Min(firstCount, firstEven.Length);

                                    var firstList = new List<int>();
                                    for (int i = 0; i < evenCount; i++)
                                    {
                                        firstList.Add(firstEven[i]);
                                    }
                                    Console.WriteLine("[{0}]", string.Join(", ", firstList));
                                }
                            }
                            else
                                Console.WriteLine("[]");
                        }
                        else if (firstEvenOrOdd == "odd")
                        {
                            var firstOdd = arr.Where(a => a % 2 == 1).ToArray();
                            if (firstOdd.Length > 0)
                            {
                                if (firstCount > arr.Count)
                                {
                                    Console.WriteLine("Invalid count");
                                    continue;
                                }
                                else
                                {
                                    var oddCount = Math.Min(firstCount, firstOdd.Length);

                                    var firstList = new List<int>();
                                    for (int i = 0; i < oddCount; i++)
                                    {
                                        firstList.Add(firstOdd[i]);
                                    }
                                    Console.WriteLine("[{0}]", string.Join(", ", firstList));
                                }
                            }
                            else
                                Console.WriteLine("[]");
                        }
                        break;
                    case "last":
                        var lastCount = int.Parse(input[1]);
                        var lastEvenOrOdd = input[2];
                        if (lastEvenOrOdd == "even")
                        {
                            var lastEven = arr.Where(a => a % 2 == 0).ToArray();
                            if (lastEven.Length > 0)
                            {
                                if (lastCount > arr.Count)
                                {
                                    Console.WriteLine("Invalid count");
                                    continue;
                                }
                                else
                                {
                                    var evenCount = Math.Min(lastCount, lastEven.Length);

                                    var lastList = new List<int>();
                                    for (int i = lastEven.Length - 1; i >= 0; i--)
                                    {
                                        lastList.Add(lastEven[i]);
                                        evenCount--;
                                        if (evenCount == 0)
                                            break;
                                    }
                                    lastList.Reverse();
                                    Console.WriteLine("[{0}]", string.Join(", ", lastList));
                                }
                            }
                            else
                                Console.WriteLine("[]");
                        }
                        else if (lastEvenOrOdd == "odd")
                        {
                            var lastOdd = arr.Where(a => a % 2 == 1).ToArray();
                            if (lastOdd.Length > 0)
                            {
                                if (lastCount > arr.Count)
                                {
                                    Console.WriteLine("Invalid count");
                                    continue;
                                }
                                else
                                {
                                    var oddCount = Math.Min(lastCount, lastOdd.Length);

                                    var lastList = new List<int>();
                                    for (int i = lastOdd.Length - 1; i >= 0; i--)
                                    {
                                        lastList.Add(lastOdd[i]);
                                        oddCount--;
                                        if (oddCount == 0)
                                            break;
                                    }
                                    lastList.Reverse();
                                    Console.WriteLine("[{0}]", string.Join(", ", lastList));
                                }
                            }
                            else
                                Console.WriteLine("[]");
                        }
                        break;
                    default: break;
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }
    }
}
