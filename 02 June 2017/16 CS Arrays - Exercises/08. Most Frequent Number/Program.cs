using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var mostFrequentNum = 0;
            var repetitions = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                var currentNum = arr[i];
                var counter = 0;

                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        counter++;
                }

                if (counter > repetitions)
                {
                    mostFrequentNum = currentNum;
                    repetitions = counter;
                }
            }
            Console.WriteLine(mostFrequentNum);
        }
    }
}
