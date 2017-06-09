using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            WriteName(name);
        }

        static void WriteName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
