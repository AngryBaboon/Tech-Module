using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string word = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                word += ch;
            }
            Console.WriteLine($"The word is: {word}");
        }
    }
}
