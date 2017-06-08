using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sentence_the_Thief
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

            double sentence = 0;

            if (id > 0)
                sentence = Math.Ceiling((double)id / sbyte.MaxValue);
            else
                sentence = Math.Ceiling((double)id / sbyte.MinValue);

            Console.WriteLine("Prisoner with id {0} is sentenced to {1} {2}", id, sentence, sentence > 1 ? "years" : "year");
        }
    }
}
