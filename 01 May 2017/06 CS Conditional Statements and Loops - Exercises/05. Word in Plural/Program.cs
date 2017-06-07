using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            if (word.EndsWith("y") == true)
                Console.WriteLine($"{word.Remove(word.Length - 1)}ies");
            else if (word.EndsWith("o") == true || word.EndsWith("ch") == true || word.EndsWith("s") == true || word.EndsWith("sh") == true || word.EndsWith("x") == true || word.EndsWith("z") == true)
                Console.WriteLine($"{word}es");
            else
                Console.WriteLine($"{word}s");
        }
    }
}
