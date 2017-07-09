using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] usernames = Regex.Replace(input, @"\W+", " ").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Regex regex = new Regex(@"^[a-zA-Z][a-zA-Z0-9_]{2,24}$");
            List<string> valid = new List<string>();

            foreach (var item in usernames)
            {
                if (regex.IsMatch(item))
                {
                    valid.Add(item);
                }
            }

            int sumMax = 0;
            string first = String.Empty;
            string second = String.Empty;

            for (int i = 1; i < valid.Count; i++)
            {
                int sum = valid[i - 1].Length + valid[i].Length;
                if (sum > sumMax)
                {
                    sumMax = sum;
                    first = valid[i - 1];
                    second = valid[i];
                }
            }
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}