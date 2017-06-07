using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();

            if (group > 120)
                Console.WriteLine("We do not have an appropriate hall.");

            else if (package == "Normal")
            {
                if (group <= 50)
                {
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {(2500 + 500) * 0.95 / group:F2}$");
                }
                if (group > 50 && group <= 100)
                {
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {(5000 + 500) * 0.95 / group:F2}$");
                }
                if (group > 100 && group <= 120)
                {
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {(7500 + 500) * 0.95 / group:F2}$");
                }
            }
            else if (package == "Gold")
            {
                if (group <= 50)
                {
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {(2500 + 750) * 0.90 / group:F2}$");
                }
                if (group > 50 && group <= 100)
                {
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {(5000 + 750) * 0.90 / group:F2}$");
                }
                if (group > 100 && group <= 120)
                {
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {(7500 + 750) * 0.90 / group:F2}$");
                }
            }
            else if (package == "Platinum")
            {
                if (group <= 50)
                {
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {(2500 + 1000) * 0.85 / group:F2}$");
                }
                if (group > 50 && group <= 100)
                {
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {(5000 + 1000) * 0.85 / group:F2}$");
                }
                if (group > 100 && group <= 120)
                {
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {(7500 + 1000) * 0.85 / group:F2}$");
                }
            }
        }
    }
}
