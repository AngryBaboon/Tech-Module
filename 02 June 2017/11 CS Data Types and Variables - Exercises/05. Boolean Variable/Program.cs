using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            if (Convert.ToBoolean(s) == true)
            Console.WriteLine("Yes");
            else if (Convert.ToBoolean(s) == false)
            Console.WriteLine("No");
        }
    }
}