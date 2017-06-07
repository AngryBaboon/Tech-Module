using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            var imperial = Console.ReadLine();
            var value = double.Parse(Console.ReadLine());

            switch (imperial)
            {
                case "miles":
                    Console.WriteLine($"{value} {imperial} = {(value * 1.6):F2} kilometers");
                    break;
                case "inches":
                    Console.WriteLine($"{value} {imperial} = {(value * 2.54):F2} centimeters");
                    break;
                case "feet":
                    Console.WriteLine($"{value} {imperial} = {(value * 30):F2} centimeters");
                    break;
                case "yards":
                    Console.WriteLine($"{value} {imperial} = {(value * 0.91):F2} meters");
                    break;
                case "gallons":
                    Console.WriteLine($"{value} {imperial} = {(value * 3.8):F2} liters");
                    break;
            }
        }
    }
}
