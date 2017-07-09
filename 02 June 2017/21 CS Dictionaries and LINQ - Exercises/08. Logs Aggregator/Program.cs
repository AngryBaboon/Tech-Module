using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var logs = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var ip = input[0];
                var name = input[1];
                var duration = int.Parse(input[2]);

                if (!logs.ContainsKey(name))
                {
                    logs.Add(name, new SortedDictionary<string, int>());
                }

                if (!logs[name].ContainsKey(ip))
                {
                    logs[name].Add(ip, 0);
                }

                logs[name][ip] += duration;
            }
            foreach (var user in logs)
            {
                var names = user.Key;
                var ipsAndDuration = user.Value;
                var totalDuration = ipsAndDuration.Sum(a => a.Value);
                var ips = ipsAndDuration.Select(a => a.Key).ToArray();

                Console.WriteLine($"{names}: {totalDuration} [{string.Join(", ", ips)}]");
            }
        }
    }
}
