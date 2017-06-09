using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var ch1 = char.Parse(Console.ReadLine());
            var ch2 = char.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            var distance1 = 0;
            var distance2 = 0;

            for (int i = 1; i <= n; i++)
            {
                var str = Console.ReadLine();

                var speed = str.Length;

                if (str == "UPGRADE")
                {
                    ch1 += (char)3;
                    ch2 += (char)3;
                    speed = 0;
                }

                if (i % 2 == 1)
                    distance1 += speed;
                else
                    distance2 += speed;

                if (distance1 >= 50)
                {
                    Console.WriteLine(ch1);
                    break;
                }
                else if (distance2 >= 50)
                {
                    Console.WriteLine(ch2);
                    break;
                }
            }

            if (distance1 < 50 && distance2 < 50)
            {
                if (distance1 > distance2)
                    Console.WriteLine(ch1);
                else if (distance2 > distance1)
                    Console.WriteLine(ch2);
            }
        }
    }
}
