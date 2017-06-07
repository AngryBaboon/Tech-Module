using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = "World";
            object sObj = s1 + ' ' + s2;
            string s3 = (string)sObj;

            Console.WriteLine(s3);
        }
    }
}
