using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().TrimStart(new char[] { '0' });
            var input2 = Console.ReadLine().TrimStart(new char[] { '0' });

            var longer = string.Empty;
            var shorter = string.Empty;

            if (input1.Length > input2.Length)
            {
                longer = input1;
                shorter = input2;
            }
            else
            {
                longer = input2;
                shorter = input1;
            }

            var output = new List<int>();
            var extra = 0;
            var shorterIndex = shorter.Length - 1;

            for (int i = longer.Length - 1; i >= 0; i--)
            {
                var placeHolder = 0;

                if (shorterIndex >= 0)
                {
                    placeHolder = int.Parse(longer[i].ToString()) + int.Parse(shorter[shorterIndex].ToString());
                }
                else
                    placeHolder = int.Parse(longer[i].ToString());

                if (extra > 0)
                {
                    placeHolder++;
                    extra = 0;
                }
                if (placeHolder > 9 && i > 0)
                {
                    output.Add(placeHolder - 10);
                    extra++;
                }
                else
                {
                    output.Add(placeHolder);
                }

                shorterIndex--;
            }

            output.Reverse();
            Console.WriteLine(string.Join("", output));
        }
    }
}
