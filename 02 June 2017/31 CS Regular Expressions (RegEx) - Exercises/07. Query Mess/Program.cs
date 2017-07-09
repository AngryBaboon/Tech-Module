using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine;

            while (!((inputLine = Console.ReadLine()) == "END"))
            {
                Regex pairs = new Regex(@"([^&=?\s]*)(?=\=)=(?<=\=)([^&=\s]*)");
                MatchCollection matches = pairs.Matches(inputLine);

                Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();
                for (int i = 0; i < matches.Count; i++)
                {
                    string field = matches[i].Groups[1].Value;
                    field = Regex.Replace(field, @"((%20|\+)+)", word => " ").Trim();

                    string value = matches[i].Groups[2].Value;
                    value = Regex.Replace(value, @"((%20|\+)+)", word => " ").Trim();

                    if (!results.ContainsKey(field))
                    {
                        List<string> values = new List<string>();
                        values.Add(value);
                        results.Add(field, values);
                    }
                    else if (results.ContainsKey(field))
                    {
                        results[field].Add(value);
                    }
                }

                foreach (var pair in results)
                {
                    Console.Write($"{pair.Key}=[{string.Join(", ", pair.Value)}]");
                }
                Console.WriteLine();
            }
        }
    }
}