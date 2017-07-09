using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var inputChars = input.ToCharArray();

            var digits = inputChars.Where(a => char.IsDigit(a)).Select(a => int.Parse(a.ToString())).ToArray();
            var letters = inputChars.Where(a => !char.IsDigit(a)).ToArray();

            var take = new List<int>();
            var skip = new List<int>();

            for (int i = 0; i < digits.Length; i++)
            {
                if (i % 2 == 0)
                {
                    take.Add(digits[i]);
                }
                else
                {
                    skip.Add(digits[i]);
                }
            }

            int totalSkip = 0;
            string output = "";
            for (int i = 0; i < take.Count; i++)
            {
                int takeCount = take[i];
                int skipCount = skip[i];

                output += new string(letters.Skip(totalSkip).Take(takeCount).ToArray());

                totalSkip += takeCount + skipCount;
            }

            Console.WriteLine(output);
        }
    }
}
