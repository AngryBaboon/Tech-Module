using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine().ToLower());

            if (Char.IsDigit(ch))
                Console.WriteLine("digit");

            else if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                Console.WriteLine("vowel");
            else
                Console.WriteLine("other");
        }
    }
}
