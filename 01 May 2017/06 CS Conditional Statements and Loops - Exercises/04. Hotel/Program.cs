using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            if (month == "May" || month == "October")
            {
                if (month == "May")
                {
                    if (nights > 7)
                        Console.WriteLine("Studio: {0:F2} lv.", 50 * nights * 0.95);
                    else
                        Console.WriteLine("Studio: {0:F2} lv.", 50 * nights);
                }
                else if (month == "October")
                {
                    if (nights > 7)
                        Console.WriteLine("Studio: {0:F2} lv.", 50 * (nights - 1) * 0.95);
                    else
                        Console.WriteLine("Studio: {0:F2} lv.", 50 * nights);
                }
                Console.WriteLine("Double: {0:F2} lv.", 65 * nights);
                Console.WriteLine("Suite: {0:F2} lv.", 75 * nights);
            }
            if (month == "June" || month == "September")
            {
                if (month == "September" && nights > 7)
                    Console.WriteLine("Studio: {0:F2} lv.", 60 * (nights - 1));
                else
                    Console.WriteLine("Studio: {0:F2} lv.", 60 * nights);
                if (nights > 14)
                    Console.WriteLine("Double: {0:F2} lv.", 72 * nights * 0.90);
                else
                    Console.WriteLine("Double: {0:F2} lv.", 72 * nights);
                Console.WriteLine("Suite: {0:F2} lv.", 82 * nights);
            }
            if (month == "July" || month == "August" || month == "December")
            {
                Console.WriteLine("Studio: {0:F2} lv.", 68 * nights);
                Console.WriteLine("Double: {0:F2} lv.", 77 * nights);
                if (nights > 14)
                    Console.WriteLine("Suite: {0:F2} lv.", 89 * nights * 0.85);
                else
                Console.WriteLine("Suite: {0:F2} lv.", 89 * nights);
            }
        }
    }
}
