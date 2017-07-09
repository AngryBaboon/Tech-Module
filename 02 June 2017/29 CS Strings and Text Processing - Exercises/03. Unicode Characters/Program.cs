using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var str = String.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                str += "\\u" + ((int)input[i]).ToString("X4").ToLower();
            }

            Console.WriteLine(str);
        }
    }
}
