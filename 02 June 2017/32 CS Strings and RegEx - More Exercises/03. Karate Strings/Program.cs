using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Karate_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            int power = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    power += int.Parse(input[i + 1].ToString());
                    i++;

                    while (i < input.Length && power > 0)
                    {
                        if (input[i] == '>') break;

                        input = input.Remove(i, 1);
                        power--;
                    }
                    i--;
                }
            }
            Console.WriteLine(input);
        }
    }
}
