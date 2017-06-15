using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var commandARR = Console.ReadLine().Split();
                var commandSTR = commandARR[0];

                switch (commandSTR)
                {
                    case "Reverse": Array.Reverse(arr); break;
                    case "Distinct": arr = arr.Distinct().ToArray(); break;
                    case "Replace": Replace(arr, commandARR); break;
                    default: break;
                }
            }
            Console.WriteLine(string.Join(", ", arr));
        }

        private static void Replace(string[] arr, string[] commandARR)
        {
            var index = int.Parse(commandARR[1]);
            var elementToReplace = commandARR[2];
            arr[index] = elementToReplace;
        }
    }
}
