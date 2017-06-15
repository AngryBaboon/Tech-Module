using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var info = Console.ReadLine().Split().ToArray();
            var phonebook = new Dictionary<string, string>();

            while (info[0] != "END")
            {
                if (info[0] == "A")
                {
                    if (phonebook.ContainsKey(info[1]))
                    {
                        phonebook.Remove(info[1]);
                    }
                    phonebook.Add(info[1], info[2]);
                }
                else if (info[0] == "S")
                {
                    if (phonebook.ContainsKey(info[1]))
                    {
                        Console.WriteLine($"{info[1]} -> {phonebook[info[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {info[1]} does not exist.");
                    }
                }
                info = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
