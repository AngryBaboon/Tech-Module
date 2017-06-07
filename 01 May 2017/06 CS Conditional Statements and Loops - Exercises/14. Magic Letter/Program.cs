using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine().ToLower());
            char end = char.Parse(Console.ReadLine().ToLower());
            char skip = char.Parse(Console.ReadLine().ToLower());

            for (char i = start; i <= end; i++)
            {
                for (char j = start; j <= end; j++)
                {
                    for (char k = start; k <= end; k++)
                    {
                        if (i != skip && j != skip && k != skip)
                            Console.Write($"{i}{j}{k} ");
                    }
                }
            }
        }
    }
}
