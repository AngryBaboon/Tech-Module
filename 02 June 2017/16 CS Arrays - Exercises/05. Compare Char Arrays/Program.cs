using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arrPlaceholder1 = arr1;
            char[] arrPlaceholder2 = arr2;

            int forLength = Math.Max(arr1.Length, arr2.Length);

            for (int i = 0; i < forLength; i++)
            {
                if (i == arr1.Length)
                {
                    arrPlaceholder1 = arr1;
                    arrPlaceholder2 = arr2;
                    break;
                }
                else if (i == arr2.Length)
                {
                    arrPlaceholder1 = arr2;
                    arrPlaceholder2 = arr1;
                    break;
                }

                if (arr1[i] == arr2[i])
                {
                    arrPlaceholder1 = arr1;
                    arrPlaceholder2 = arr2;
                }
                else if (arr1[i] != arr2[i])
                {
                    if (arr1[i] < arr2[i])
                    {
                        arrPlaceholder1 = arr1;
                        arrPlaceholder2 = arr2;
                    }
                    else if (arr1[i] > arr2[i])
                    {
                        arrPlaceholder1 = arr2;
                        arrPlaceholder2 = arr1;
                    }
                }
            }
            Console.WriteLine(arrPlaceholder1);
            Console.WriteLine(arrPlaceholder2);
        }
    }
}
