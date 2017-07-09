using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        class Driver
        {
            public string Name { get; set; }
            public double Fuel { get; set; }
            public int Zone { get; set; }
        }

        static void Main(string[] args)
        {
            var regex = new Regex(@"\s+");

            var names = regex.Split(Console.ReadLine()).ToList();
            var zones = regex.Split(Console.ReadLine()).Select(double.Parse).ToArray();
            var checkpoint = regex.Split(Console.ReadLine()).Select(int.Parse).ToArray();

            var classDriver = new Driver();
            var listDriver = new List<Driver>();

            for (int i = 0; i < names.Count; i++)
            {
                classDriver = new Driver
                {
                    Name = names[i],
                    Fuel = names[i].First(),
                    Zone = 0
                };

                listDriver.Add(classDriver);

                for (int j = 0; j < zones.Length; j++)
                {
                    if (classDriver.Fuel > 0)
                    {
                        if (checkpoint.Contains(j))
                        {
                            classDriver.Fuel += zones[j];
                            classDriver.Zone = j;
                        }
                        else
                        {
                            classDriver.Fuel -= zones[j];
                            classDriver.Zone = j;
                        }
                    }
                }
            }

            foreach (var driver in listDriver)
            {
                if (driver.Fuel > 0)
                {
                    Console.WriteLine($"{driver.Name} - fuel left {driver.Fuel:F2}");
                }
                else
                {
                    Console.WriteLine($"{driver.Name} - reached {driver.Zone}");
                }
            }
        }
    }
}
