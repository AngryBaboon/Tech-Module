using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n/2-1; i++)
            {
                string space = new string(' ', n - 2 - i*2);
                string space2 = new string(' ', i);
                Console.WriteLine(space2 + 'x'+ space + 'x');
            }

            string space3 = new string(' ', n / 2);
            Console.WriteLine(space3 + 'x');

            for (int i = 0; i <= n / 2 - 1; i++)
            {
                string space = new string(' ', 1 + i*2);
                string space2 = new string(' ', n / 2 - i - 1);
                Console.WriteLine(space2 + 'x' + space + 'x');
            }
        }
    }
}
