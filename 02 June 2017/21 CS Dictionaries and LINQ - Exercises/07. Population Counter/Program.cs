using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');

            var countries = new Dictionary<string, List<string>>();
            var cities = new SortedDictionary<string, long>();
            var totalPopulation = new Dictionary<string, long>();

            while (input[0] != "report")
            {
                var cityInput = input[0];
                var countryInput = input[1];
                var populationInput = long.Parse(input[2]);

                if (!cities.ContainsKey(cityInput))
                {
                    cities.Add(cityInput, populationInput);
                }

                if (!countries.ContainsKey(countryInput))
                {
                    countries.Add(countryInput, new List<string>());
                }

                if (!totalPopulation.ContainsKey(countryInput))
                {
                    totalPopulation.Add(countryInput, 0);
                }

                countries[countryInput].Add(cityInput);
                totalPopulation[countryInput] += populationInput;

                input = Console.ReadLine().Split('|');
            }

            var totalCountryPopulationList = totalPopulation.OrderByDescending(key => key.Value).ToList();
            var cityList = cities.OrderByDescending(key => key.Value).ToList();

            foreach (var item in totalCountryPopulationList)
            {
                var country = item.Key;
                var countryPopulation = item.Value;

                Console.WriteLine($"{country} (total population: {countryPopulation})");
                foreach (var allCities in cityList)
                {
                    foreach (var city in countries[country])
                    {
                        if (city == allCities.Key)
                        {
                            Console.WriteLine($"=>{city}: {allCities.Value}");
                        }
                    }
                }

            }
        }
    }
}