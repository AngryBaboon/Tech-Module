using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Srubsko_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            var cityProfit = new Dictionary<string, Dictionary<string, long>>();

            string[] singerInfo = ReadInfo();

            while (!singerInfo[0].Equals("End"))
            {
                if (!singerInfo[0][singerInfo[0].Length - 1].Equals(' '))
                    singerInfo = ReadInfo();
                else
                {
                    var leftPart = singerInfo[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var rightPart = singerInfo[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var singer = string.Join(" ", leftPart);

                    if (rightPart.Length - 2 > 0)
                    {
                        var cityAsString = new string[rightPart.Length - 2];

                        for (int i = 0; i < cityAsString.Length; i++)
                        {
                            cityAsString[i] = rightPart[i];
                        }

                        int ticketPrice, ticketCount;
                        long profit;

                        if (int.TryParse(rightPart[rightPart.Length - 1], out ticketCount) &&
                            int.TryParse(rightPart[rightPart.Length - 2], out ticketPrice))
                        {
                            profit = ticketPrice * ticketCount;
                            string newCity = string.Join(" ", cityAsString);
                            InsertCity(cityProfit, newCity);
                            InsertProfit(cityProfit, newCity, singer, profit);
                            singerInfo = ReadInfo();
                        }
                        else
                            singerInfo = ReadInfo();

                    }
                    else
                        singerInfo = ReadInfo();
                }
            }

            PrintProfit(cityProfit);
        }

        private static string[] ReadInfo()
        {
            var singerInfo = Console.ReadLine().Split('@').ToArray();
            return singerInfo;
        }

        private static void PrintProfit(Dictionary<string, Dictionary<string, long>> cityProfit)
        {
            foreach (KeyValuePair<string, Dictionary<string, long>> cityEntry in cityProfit)
            {
                Console.WriteLine(cityEntry.Key);

                foreach (KeyValuePair<string, long> singerProfit in cityEntry.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singerProfit.Key} -> {singerProfit.Value}");
                }
            }
        }

        private static void InsertProfit(Dictionary<string, Dictionary<string, long>> cityProfit, string newCity, string singer, long profit)
        {
            if (!cityProfit[newCity].ContainsKey(singer))
            {
                cityProfit[newCity].Add(singer, 0);
            }
            cityProfit[newCity][singer] += profit;
        }

        private static void InsertCity(Dictionary<string, Dictionary<string, long>> cityProfit, string newCity)
        {
            if (!cityProfit.ContainsKey(newCity))
                cityProfit.Add(newCity, new Dictionary<string, long>());
        }
    }
}
