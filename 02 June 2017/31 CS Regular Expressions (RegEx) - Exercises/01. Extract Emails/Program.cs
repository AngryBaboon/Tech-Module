using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Regex.Matches(Console.ReadLine(), @"(?<=\s)[A-Za-z0-9]+[\w.-][A-Za-z0-9]+@[a-z]+([.-][a-z]+)+");

            foreach (var match in input)
            {
                Console.WriteLine(match);
            }
        }
    }
}
