using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            var numType = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            long id = long.MinValue;

            for (int i = 1; i <= n; i++)
            {
                var tempId = long.Parse(Console.ReadLine());

                switch (numType)
                {
                    case "sbyte":
                        if (tempId >= sbyte.MinValue && tempId <= sbyte.MaxValue)
                        {
                            if (id < tempId)
                                id = tempId;
                        }
                        break;
                    case "int":
                        if (tempId >= int.MinValue && tempId <= int.MaxValue)
                        {
                            if (id < tempId)
                                id = tempId;
                        }
                        break;
                    case "long":
                        if (tempId >= long.MinValue && tempId <= long.MaxValue)
                        {
                            if (id < tempId)
                                id = tempId;
                        }
                        break;
                    default: break;
                }
            }
            Console.WriteLine(id);
        }
    }
}