using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Mines
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var startIndex = 0;
            var endIndex = 0;

            while ((startIndex = input.IndexOf("<", startIndex)) != -1
                && (endIndex = input.IndexOf(">", startIndex)) != -1)
            {
                var destroyedChars = input.Substring(startIndex + 1, 2);
                var bombStrength = Math.Abs(destroyedChars[0] - destroyedChars[1]);

                var left = Math.Max(0, startIndex - bombStrength);
                var right = Math.Min(input.Length - 1, endIndex + bombStrength);

                var sb = new StringBuilder(input);

                for (int i = left; i <= right; i++)
                {
                    sb[i] = '_';
                }

                input = sb.ToString();
            }
            Console.WriteLine(input);
        }
    }
}
