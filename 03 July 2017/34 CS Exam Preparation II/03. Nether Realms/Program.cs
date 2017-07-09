using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        class Demon
        {
            public string Name { get; set; }
            public decimal Health { get; set; }
            public decimal Damage { get; set; }
        }

        static void Main(string[] args)
        {
            var input = Regex.Split(Console.ReadLine(), @"\s*,\s*");

            var list = new List<Demon>();

            foreach (var demon in input)
            {
                var health = Regex.Matches(demon, @"[^\d\+\-\*\/\.]")
                    .Cast<Match>()
                    .Select(a => (int)char.Parse(a.Value))
                    .Sum();

                var damage = Regex.Matches(demon, @"-*\d+(\.\d+)*")
                    .Cast<Match>()
                    .Select(a => decimal.Parse(a.Value))
                    .Sum();

                var damageSigns = demon
                    .Where(a => a == '*' || a == '/')
                    .ToArray();

                foreach (var sign in damageSigns)
                {
                    if (sign == '*')
                    {
                        damage *= 2;
                    }
                    else if (sign == '/')
                    {
                        damage /= 2;
                    }
                }

                var classDemon = new Demon
                {
                    Name = demon,
                    Health = health,
                    Damage = damage
                };

                list.Add(classDemon);
            }

            foreach (var demon in list.OrderBy(a => a.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health:F0} health, {demon.Damage:F2} damage");
            }
        }
    }
}
