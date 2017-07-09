using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyword = Console.ReadLine().Trim();
            var input = Console.ReadLine().Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string sentence in input)
            {
                var words = Regex.Split(sentence, "[^A-Za-z]");
                if (words.Contains(keyword))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
