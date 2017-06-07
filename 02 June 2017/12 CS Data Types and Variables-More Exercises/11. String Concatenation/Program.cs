using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            var delimiter = char.Parse(Console.ReadLine());
            var evenOrOdd = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            string s = String.Empty;

            for (int i = 1; i <= n; i++)
            {
                var word = Console.ReadLine();

                if (evenOrOdd == "even" && i % 2 == 0)
                    s += word + delimiter;

                else if (evenOrOdd == "odd" && i % 2 == 1)
                    s += word + delimiter;
            }
            Console.WriteLine(s.TrimEnd(delimiter, ' '));
        }
    }
}
