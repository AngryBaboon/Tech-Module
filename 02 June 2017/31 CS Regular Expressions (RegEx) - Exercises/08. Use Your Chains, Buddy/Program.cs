using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Use_Your_Chains__Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"<p>(?<message>.+?)<\/p>");

            var input = Console.ReadLine();

            var paragraphs = regex.Matches(input)
                .Cast<Match>()
                .Select(a => a.Groups["message"].Value)
                .Select(a => Regex.Replace(a, @"[^a-z0-9]+", " "))
                .Select(a => Regex.Replace(a, @"\s+", " "))
                .ToArray();

            for (int i = 0; i < paragraphs.Length; i++)
            {
                paragraphs[i] = Rotate13String(paragraphs[i]);
            }

            var output = new StringBuilder();

            foreach (var paragraph in paragraphs)
            {
                output.Append(paragraph);
            }

            Console.WriteLine(output.ToString());
        }

        private static string Rotate13String(string input)
        {
            var result = new StringBuilder();

            foreach (var letter in input)
            {
                result.Append(Rotate13(letter));
            }

            return result.ToString();
        }

        private static char Rotate13(char letter)
        {
            if (!char.IsLetter(letter))
            {
                return letter;
            }

            var offset = char.IsUpper(letter) ? 'A' : 'a';

            var rotatedLetter = (char)((letter - offset + 13) % 26 + offset);

            return rotatedLetter;
        }
    }
}
