using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Email_me
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = Console.ReadLine().Split('@');

            var leftSide = email[0].ToCharArray();
            var rightSide = email[1].ToCharArray();

            var leftSum = 0;
            var rightSum = 0;

            for (int i = 0; i < leftSide.Length; i++)
            {
                leftSum += leftSide[i];
            }
            for (int i = 0; i < rightSide.Length; i++)
            {
                rightSum += rightSide[i];
            }

            if (leftSum - rightSum >= 0)
                Console.WriteLine("Call her!");
            else
                Console.WriteLine("She is not the one.");
        }
    }
}
