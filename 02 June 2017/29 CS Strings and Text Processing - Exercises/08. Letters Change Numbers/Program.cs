using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            var sum = 0d;

            foreach (var str in input)
            {
                var firstLetter = str.First();
                var lastLetter = str.Last();

                var num = double.Parse(str.Substring(1, str.Length - 2));

                if (char.IsUpper(firstLetter))
                {
                    num /= firstLetter - ('A' - 1);
                }
                else
                {
                    num *= firstLetter - ('a' - 1);
                }
                if (char.IsUpper(lastLetter))
                {
                    num -= lastLetter - ('A' - 1);
                }
                else
                {
                    num += lastLetter - ('a' - 1);
                }

                sum += num;
            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}
