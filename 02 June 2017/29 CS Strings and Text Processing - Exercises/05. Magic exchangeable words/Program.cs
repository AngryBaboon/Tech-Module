using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            CheckIfExchangeable(input);

            Console.WriteLine(CheckIfExchangeable(input).ToString().ToLower());
        }

        private static bool CheckIfExchangeable(string[] input)
        {
            var str1 = input[0];
            var str2 = input[1];

            var longer = string.Empty;
            var shorter = string.Empty;

            if (str1.Length >= str2.Length)
            {
                longer = str1;
                shorter = str2;
            }
            else
            {
                longer = str2;
                shorter = str1;
            }

            var chars = new Dictionary<char, char>();

            for (int i = 0; i < longer.Length; i++)
            {
                if (shorter.Length > i)
                {
                    if (!chars.ContainsKey(str1[i]))
                    {
                        if (!chars.ContainsValue(str2[i]))
                        {
                            chars.Add(str1[i], str2[i]);
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (chars[str1[i]] != str2[i])
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (!chars.ContainsKey(longer[i]) && !chars.ContainsValue(longer[i]))
                    {
                        return false;
                    }
                    else
                        continue;
                }
            }
            return true;
        }
    }
}
