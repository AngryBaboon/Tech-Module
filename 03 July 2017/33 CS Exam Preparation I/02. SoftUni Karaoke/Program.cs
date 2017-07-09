using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\s*,\s*");

            var listOfParticipants = regex.Split(Console.ReadLine()).ToList();
            var listOfSongs = regex.Split(Console.ReadLine()).ToList();

            var dict = new Dictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "dawn") break;

                var input2 = regex.Split(input).ToList();

                var person = input2[0];
                var song = input2[1];
                var award = input2[2];

                if (listOfParticipants.Contains(person) && listOfSongs.Contains(song) && !dict.ContainsKey(person))
                {
                    dict.Add(person, new List<string>());
                    dict[person].Add(award);
                }
                else if (listOfParticipants.Contains(person) && listOfSongs.Contains(song) && dict.ContainsKey(person) && !dict[person].Contains(award))
                {
                    dict[person].Add(award);
                }
            }

            if (dict.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            var output = dict
                .Select(a => new
                {
                    person = a.Key,
                    award = a.Value.OrderBy(name => name),
                    awardCount = a.Value.Count()
                })
                .OrderByDescending(a => a.awardCount)
                .ThenBy(a => a.person)
                .ToArray();

            foreach (var player in output)
            {
                Console.WriteLine($"{player.person}: {player.awardCount} awards");

                foreach (var award in player.award)
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
