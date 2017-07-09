using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var charArr1 = input[0].ToCharArray();
            var charArr2 = input[1].ToCharArray();

            var sum = 0;

            var minLength = Math.Min(input[0].Length, input[1].Length);
            var maxLength = Math.Max(input[0].Length, input[1].Length);

            for (int i = 0; i < minLength; i++)
            {
                sum += charArr1[i] * charArr2[i];
            }

            if (minLength != maxLength)
            {
                if (input[0].Length > input[1].Length)
                {
                    for (int i = minLength; i < maxLength; i++)
                    {
                        sum += charArr1[i];
                    }
                }
                else
                {
                    for (int i = minLength; i < maxLength; i++)
                    {
                        sum += charArr2[i];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
