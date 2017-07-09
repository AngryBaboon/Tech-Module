using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var end = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var holidays = new[]
            {
                "01 01",
                "03 03",
                "01 05",
                "06 05",
                "24 05",
                "06 09",
                "22 09",
                "01 11",
                "24 12",
                "25 12",
                "26 12",
            }
            .Select(a => DateTime.ParseExact(a, "dd MM", CultureInfo.InvariantCulture));

            var counter = 0;

            for (DateTime i = start; i <= end; i = i.AddDays(1))
            {
                if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday && !holidays.Any(a => a.Day == i.Day && a.Month == i.Month))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
