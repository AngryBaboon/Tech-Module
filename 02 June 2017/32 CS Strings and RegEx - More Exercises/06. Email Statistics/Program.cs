using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Email_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\b(?<username>[A-Za-z]{5,})@(?<domain>[a-z]{3,}[.](com|org|bg))\b");

            var n = int.Parse(Console.ReadLine());

            var emails = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                var inputEmails = Console.ReadLine();

                var match = regex.Match(inputEmails);

                if (match.Success)
                {
                    var username = match.Groups["username"].Value;
                    var domain = match.Groups["domain"].Value;

                    if (!emails.ContainsKey(domain))
                    {
                        emails[domain] = new List<string>();
                    }

                    if (!emails[domain].Contains(username))
                    {
                        emails[domain].Add(username);
                    }
                }
            }
            foreach (KeyValuePair<string, List<string>> item in emails.OrderByDescending(a => a.Value.Count))
            {
                Console.WriteLine($"{item.Key}:");

                foreach (var username in item.Value.ToList())
                {
                    Console.WriteLine($"### {username}");
                }
            }
        }
    }
}
