using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            string s = String.Empty;

            for (int i = 0; i < n; i++)
            {
                var ch = char.Parse(Console.ReadLine());
                var decrypt = ch + key;

                s += (char)decrypt;
            }
            Console.WriteLine(s);
        }
    }
}