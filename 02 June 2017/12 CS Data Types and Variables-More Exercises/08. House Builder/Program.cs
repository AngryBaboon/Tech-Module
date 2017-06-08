using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = long.Parse(Console.ReadLine());
            var n2 = long.Parse(Console.ReadLine());

            long totalPrice = 0;

            if (n1 <= sbyte.MaxValue && n2 > sbyte.MaxValue)
                totalPrice = (n1 * 4) + (n2 * 10);
            else
                totalPrice = (n2 * 4) + (n1 * 10);

            Console.WriteLine(totalPrice);
        }
    }
}
