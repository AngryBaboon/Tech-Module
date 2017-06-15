using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] info = new string[2];
            var index = 0;
            var nameAndEmail = new Dictionary<string, string>();

            while (true)
            {
                if (index % 2 == 0)
                {
                    info[0] = Console.ReadLine();

                    if (info[0] == "stop") break;
                }
                else
                {
                    info[1] = Console.ReadLine();

                    if (info[1].Substring(info[1].Length - 2) != "us" || info[1].Substring(info[1].Length - 2) != "uk")
                    {
                        nameAndEmail.Add(info[0], info[1]);
                    }
                }
                index++;
            }
            foreach (var item in nameAndEmail)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
