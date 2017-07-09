using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var userLogs = new SortedDictionary<string, Dictionary<string, int>>();

            while (!input.Equals("end"))
            {
                string[] log = input.Split(new string[] { "IP=", "message=", "user=", " " }, StringSplitOptions.RemoveEmptyEntries);
                var ip = log[0];
                var user = log[2];

                var counter = 1;

                if (!userLogs.ContainsKey(user))
                {
                    userLogs.Add(user, new Dictionary<string, int>());
                }
                if (!userLogs[user].ContainsKey(ip))
                {
                    userLogs[user].Add(ip, counter);
                }
                else
                    userLogs[user][ip]++;

                input = Console.ReadLine();
            }

            foreach (var user in userLogs)
            {
                Console.WriteLine($"{user.Key}: ");

                foreach (var log in user.Value)
                {
                    if (log.Key != user.Value.Keys.Last())
                    {
                        Console.Write($"{log.Key} => {log.Value}, ");
                    }
                    else
                        Console.WriteLine($"{log.Key} => {log.Value}.");
                }
            }
        }
    }
}
