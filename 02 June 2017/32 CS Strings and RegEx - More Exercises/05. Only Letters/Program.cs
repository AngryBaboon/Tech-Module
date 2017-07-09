using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Only_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var match = Regex.Match(input, @"(?<= \d*)");


            input = Regex.Replace(input, @"\d *", match);

            Console.WriteLine(input);
        }
    }
}
