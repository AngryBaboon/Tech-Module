using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var magic = int.Parse(Console.ReadLine());
            int comb = 0;

            for (int i = M; i >= N; i--)
            {
                for (int j = M; j >= N; j--)
                {
                    comb++;

                    if (i + j == magic)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magic}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{comb} combinations - neither equals {magic}");
        }
    }
}