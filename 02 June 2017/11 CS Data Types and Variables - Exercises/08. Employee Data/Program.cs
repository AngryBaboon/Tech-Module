using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = "Amanda";
            string lastname = "Jonson";
            sbyte age = 27;
            char gender = 'f';
            long id = 8306112507;
            int number = 27563571;

            Console.WriteLine($"First name: {firstname}");
            Console.WriteLine($"Last name: {lastname}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {id}");
            Console.WriteLine($"Unique Employee number: {number}");
        }
    }
}
