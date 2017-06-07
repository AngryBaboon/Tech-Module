using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 4; i++)
            {
                for (int i2 = 1; i2 <= 4; i2++)
                {
                    for (int i3 = 1; i3 <= 4; i3++)
                    {
                        if (i + i2 + i3 >= sum)
                        {
                            Console.Write("O");
                            switch (i)
                            {
                                case 1: Console.Write("A"); break;
                                case 2: Console.Write("C"); break;
                                case 3: Console.Write("G"); break;
                                case 4: Console.Write("T"); break;
                            }
                            switch (i2)
                            {
                                case 1: Console.Write("A"); break;
                                case 2: Console.Write("C"); break;
                                case 3: Console.Write("G"); break;
                                case 4: Console.Write("T"); break;
                            }
                            switch (i3)
                            {
                                case 1: Console.Write("A"); break;
                                case 2: Console.Write("C"); break;
                                case 3: Console.Write("G"); break;
                                case 4: Console.Write("T"); break;
                            }
                            Console.Write("O ");
                        }
                        else
                        {
                            Console.Write("X");
                            switch (i)
                            {
                                case 1: Console.Write("A"); break;
                                case 2: Console.Write("C"); break;
                                case 3: Console.Write("G"); break;
                                case 4: Console.Write("T"); break;
                            }
                            switch (i2)
                            {
                                case 1: Console.Write("A"); break;
                                case 2: Console.Write("C"); break;
                                case 3: Console.Write("G"); break;
                                case 4: Console.Write("T"); break;
                            }
                            switch (i3)
                            {
                                case 1: Console.Write("A"); break;
                                case 2: Console.Write("C"); break;
                                case 3: Console.Write("G"); break;
                                case 4: Console.Write("T"); break;
                            }
                            Console.Write("X ");
                        }

                    }
                    Console.WriteLine();
                }
            }
        }
    }
}