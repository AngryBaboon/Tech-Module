using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var num = long.Parse(Console.ReadLine());

                if (num <= sbyte.MaxValue && num >= sbyte.MinValue)
                    Console.WriteLine("Sunny");

                else if (num <= int.MaxValue && num >= int.MinValue)
                    Console.WriteLine("Cloudy");

                else if (num <= long.MaxValue && num >= long.MinValue)
                    Console.WriteLine("Windy");
            }
            catch (Exception)
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
