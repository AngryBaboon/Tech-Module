using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToUpper();

            var output = new StringBuilder();

            var matches = Regex.Matches(input, @"(?<text>\D+)(?<number>\d+)");

            foreach (Match match in matches)
            {
                var text = match.Groups["text"].Value;
                var repeats = int.Parse(match.Groups["number"].Value);

                for (int i = 0; i < repeats; i++)
                {
                    output.Append(text);
                }
            }

            Console.WriteLine($"Unique symbols used: {output.ToString().Distinct().Count()}");
            Console.WriteLine(output);
        }
    }
}
