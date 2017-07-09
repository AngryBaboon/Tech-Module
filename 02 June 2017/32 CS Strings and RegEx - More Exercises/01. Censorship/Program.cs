using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var sentence = Console.ReadLine().Split();

            var stars = new string('*', word.Length);

            for (int i = 0; i < sentence.Length; i++)
            {
                var match = Regex.Match(sentence[i], $@"(?<left>[A-Za-z\d]*){word}(?<right>[A-Za-z\d]*)");

                if (match.Success)
                {
                    sentence[i] = $"{match.Groups["left"]}{stars}{match.Groups["right"]}";
                }
            }
            Console.WriteLine(string.Join(" ", sentence));
        }
    }
}
