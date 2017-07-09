using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Cubic_Messages
{
    class Program
    {
        private static object regex;

        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Over!") break;
                var m = int.Parse(Console.ReadLine());

                var match = Regex.Match(input, $@"^(?<digits1>\d+)(?<text>[A-Za-z]{{{m}}})(?<digits2>\d*[^A-Za-z]*)$");

                if (match.Success)
                {
                    var text = match.Groups["text"].ToString();

                    var digits = (match.Groups["digits1"].Value + match.Groups["digits2"].Value).Where(char.IsDigit).ToArray();

                    var code = string.Empty;
                    for (int i = 0; i < digits.Length; i++)
                    {
                        var index = int.Parse(digits[i].ToString());

                        if (index < text.Length)
                        {
                            code += text[index];
                        }
                        else
                        {
                            code += " ";
                        }
                    }

                    Console.WriteLine($"{text} == {code}");
                }
            }
        }
    }
}
