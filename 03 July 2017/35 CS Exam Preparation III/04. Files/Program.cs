using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var match = Regex.Match(input, @"(?<root>[\w:]*)\\([\w\.]*\\)*(?<file>[\w. ]*\.\w*);(?<size>\d*)");

                if (match.Success)
                {
                    var root = match.Groups["root"].Value;
                    var file = match.Groups["file"].Value;
                    var size = int.Parse(match.Groups["size"].Value);

                    if (!dict.ContainsKey(root))
                    {
                        dict.Add(root, new Dictionary<string, int>());
                    }

                    dict[root].Add(file, size);
                }
            }

            var query = Console.ReadLine().Split();

            var outputRoot = query[2];
            var outputExtention = query[0];

            var extentionLenght = outputExtention.Length;

            var output = dict.Select(a => new
            {
                Root = a.Key,
                File = a.Value.Select(b => b.Key),
                Size = a.Value.Select(b => b.Value)
            })
            .Where(a => a.Root == outputRoot)
            .OrderBy(a => a.Size)
            .ThenBy(a => a.File)
            .ToList();

            foreach (var file in output)
            {
                Console.WriteLine($"{file.} - {file.Size} KB");
            }
        }
    }
}
