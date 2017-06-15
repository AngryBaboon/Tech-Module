using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] resource = new string[1];
            int[] quantity = new int[1];
            var resourceQuantity = new Dictionary<string, int>();
            var index = 0;

            while (true)
            {
                if (index % 2 == 0)
                {
                    resource[0] = Console.ReadLine();

                    if (resource[0] == "stop") break;
                }
                else
                {
                    quantity[0] = int.Parse(Console.ReadLine());

                    if (resourceQuantity.ContainsKey(resource[0]))
                    {
                        resourceQuantity[resource[0]] += quantity[0];
                    }
                    else
                        resourceQuantity.Add(resource[0], quantity[0]);
                }
                index++;
            }
            foreach (var entry in resourceQuantity)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}
