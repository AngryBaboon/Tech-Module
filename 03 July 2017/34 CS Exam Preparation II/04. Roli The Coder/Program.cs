using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventDict = new Dictionary<string, List<string>>();
            var idList = new List<int>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Time for Code") break;

                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!Regex.Match(tokens[1], "#").Success)
                {
                    continue;
                }

                var reset = 0;
                for (int i = 2; i < tokens.Length; i++)
                {
                    if (!Regex.Match(tokens[i], "@").Success)
                    {
                        reset = 1;
                        break;
                    }
                }
                if (reset == 1)
                {
                    continue;
                }

                var id = int.Parse(tokens[0]);
                var eventName = string.Empty;
                var participant = string.Empty;

                foreach (var item in tokens)
                {
                    var matchEventName = Regex.Match(item, "#");
                    var matchParticipantName = Regex.Match(item, "@");

                    if (matchEventName.Success)
                    {
                        eventName = item.TrimStart('#');

                        if (!eventDict.ContainsKey(eventName) && !idList.Contains(id))
                        {
                            eventDict.Add(eventName, new List<string>());
                            idList.Add(id);
                        }
                    }
                    else if (matchParticipantName.Success)
                    {
                        participant = item;

                        if (eventDict.ContainsKey(eventName) && !eventDict[eventName].Contains(participant))
                        {
                            eventDict[eventName].Add(participant);
                        }
                    }
                }
            }

            var output = eventDict.OrderByDescending(a => a.Value.Count).ThenBy(a => a.Key).ToList();

            foreach (var @event in output)
            {
                Console.WriteLine($"{@event.Key} - {@event.Value.Count}");

                foreach (var participant in @event.Value.OrderBy(a => a))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
