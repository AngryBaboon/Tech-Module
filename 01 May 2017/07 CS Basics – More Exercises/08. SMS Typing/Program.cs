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
            string SMS = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                    SMS += ' ';

                else
                {
                    int numOfDigits = num.ToString().Length;
                    int mainDigit = num % 10;
                    int offset = (mainDigit - 2) * 3;

                    if (mainDigit == 8 || mainDigit == 9)
                    {
                        offset++;
                    }

                    int letterIndex = offset + numOfDigits - 1;
                    int code = letterIndex + 97;

                    SMS += (char)code;
                }
            }
            Console.WriteLine(SMS);
        }
    }
}