using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());

                var numOfDigits = num.ToString().Length;
                var mainDigit = num.ToString()[0];
                var offset = (mainDigit - 2) * 3;

                if (mainDigit == 7 || mainDigit == 9)
                {
                    offset++;
                }

                var letterIndex = offset + numOfDigits - 1;
                var code = letterIndex + 97;
                Console.WriteLine("{0} {1}", numOfDigits, mainDigit);
                Console.WriteLine((char)code);
            }
        }
    }
}
// Not Finished