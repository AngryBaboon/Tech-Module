using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (true)
            {
                var input2 = Console.ReadLine().Split();

                var match = Regex.Match(input, $@"\{input2[0]}{{{input2[1]},}}");

                if (match.Success)
                {
                    Console.WriteLine($"Hideout found at index {input.IndexOf(match.Value)} and it is with size {match.Value.Length}!");
                    break;
                }
            }
        }
    }
}
