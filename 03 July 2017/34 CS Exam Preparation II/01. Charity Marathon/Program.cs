using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var daysOfMarathon = decimal.Parse(Console.ReadLine());
            var allRunners = decimal.Parse(Console.ReadLine());
            var laps = decimal.Parse(Console.ReadLine());
            var lapLength = decimal.Parse(Console.ReadLine());
            var trackCapacity = decimal.Parse(Console.ReadLine());
            var moneyPerKm = decimal.Parse(Console.ReadLine());

            decimal moneyRaised = 0;

            if (allRunners > trackCapacity)
            {
                decimal runnersLeft = allRunners;
                decimal runners = 0;

                for (int i = 0; i < daysOfMarathon; i++)
                {
                    if (runnersLeft > trackCapacity)
                    {
                        runners = trackCapacity;
                        runnersLeft -= trackCapacity;
                    }
                    else
                        runners = runnersLeft;

                    decimal totalMeters = runners * laps * lapLength;
                    decimal totalKm = totalMeters / 1000;
                    moneyRaised += totalKm * moneyPerKm;
                }
            }
            else if (allRunners <= trackCapacity && daysOfMarathon > 0)
            {
                decimal totalMeters = allRunners * laps * lapLength;
                decimal totalKm = totalMeters / 1000;
                moneyRaised = totalKm * moneyPerKm;
            }
            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}
