using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04.Punctuation_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines(@"..\..\sample_text.txt");
            var punctuationToTake = new char[] { '.', ',', ':', '?', '!' };
            List<char> punctuation = new List<char>();

            foreach (var line in input)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (punctuationToTake.Contains(line[i]))
                    {
                        punctuation.Add(line[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", punctuation));
        }
    }
}