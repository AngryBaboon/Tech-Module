using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            for (int i = 0; i < 100; i++)
            {
                try
                {

                    var a = int.Parse(Console.ReadLine());
                    n++;
                }
                catch (Exception)
                {
                    Console.WriteLine(n); break;
                }
            }
        }
    }
}
