using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var health = int.Parse(Console.ReadLine());
            var initialHealth = health;

            var virusList = new List<string>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end") break;

                int virusSTR = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    virusSTR += input[i];
                }
                virusSTR = (int)(virusSTR / 3.0);

                var timeToDefeat = 0;

                if (!virusList.Contains(input))
                {
                    virusList.Add(input);
                    timeToDefeat = virusSTR * input.Length;
                }
                else
                {
                    timeToDefeat = (int)((virusSTR * input.Length) / 3.0);
                }

                health -= timeToDefeat;

                var time = timeToDefeat / 60 + "m " + timeToDefeat % 60 + "s";

                Console.WriteLine($"Virus {input}: {virusSTR} => {timeToDefeat} seconds");
                if (health > 0)
                {
                    Console.WriteLine($"{input} defeated in {time}.");
                    Console.WriteLine($"Remaining health: {health}");

                    var regainSTR = health + (int)(health * 0.20);
                    if (regainSTR <= initialHealth)
                        health = regainSTR;
                    else
                        health = initialHealth;
                }
                else
                    break;
            }

            if (health > 0)
                Console.WriteLine($"Final Health: {health}");
            else
                Console.WriteLine("Immune System Defeated.");
        }
    }
}
