using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split();

            while (true)
            {
                var commandARR = Console.ReadLine().Split();
                var commandSTR = commandARR[0];

                if (commandSTR == "END")
                    break;

                switch (commandSTR)
                {
                    case "Reverse": Array.Reverse(arr); break;
                    case "Distinct": arr = arr.Distinct().ToArray(); break;
                    case "Replace":
                        var index = int.Parse(commandARR[1]);

                        if (index < 0 || index >= arr.Length)
                        {
                            Console.WriteLine("Invalid input!");
                            break;
                        }

                        var elementToReplace = commandARR[2];
                        arr[index] = elementToReplace;
                        break;
                    default: Console.WriteLine("Invalid input!"); break;
                }
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
