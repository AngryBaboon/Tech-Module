using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Program
    {
        class WeatherInfo
        {
            public double Temp { get; set; }
            public string Weather { get; set; }
        }

        static void Main(string[] args)
        {
            var regex = new Regex(@"(?<city>[A-Z]{2})(?<temp>\d+\.\d+)(?<weather>[A-Za-z]+)\|");
            var dict = new Dictionary<string, WeatherInfo>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end") break;

                Match matchedInput = regex.Match(input);

                if (matchedInput.Success)
                {
                    var city = matchedInput.Groups["city"].Value;
                    var temp = double.Parse(matchedInput.Groups["temp"].Value);
                    var weather = matchedInput.Groups["weather"].Value;

                    var classWeatherInfo = new WeatherInfo()
                    {
                        Temp = temp,
                        Weather = weather
                    };

                    dict[city] = classWeatherInfo;
                }
            }

            var output = dict.OrderBy(a => a.Value.Temp);

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} => {item.Value.Temp:F2} => {item.Value.Weather}");
            }
        }
    }
}
