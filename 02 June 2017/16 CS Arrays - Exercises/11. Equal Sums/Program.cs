using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> index = new List<int>();

            for (int i = 0; i < arr.Length; i++)
                if (arr.Take(i).Sum() == arr.Skip(i + 1).Take(arr.Length - i).Sum())
                {
                    index.Add(i);
                }

            if (index.Count > 0)
                Console.WriteLine(string.Join(", ", index));
            else
                Console.WriteLine("no");
        }
    }
}
