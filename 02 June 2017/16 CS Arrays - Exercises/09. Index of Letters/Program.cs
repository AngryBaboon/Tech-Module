using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            char[] arrLetters = new char[26];

            for (int i = 0; i < 26; i++)
            {
                arrLetters[i] = (char)(i + 97);
            }

            int index1 = 0;
            int index2 = 0;

            while (index2 < word.Length)
            {
                if (arrLetters[index1] == word[index2])
                {
                    Console.WriteLine("{0} -> {1}", arrLetters[index1], index1);
                    index2++;
                }

                if (index1 < 25)
                    index1++;
                else
                    index1 = 0;
            }
        }
    }
}
