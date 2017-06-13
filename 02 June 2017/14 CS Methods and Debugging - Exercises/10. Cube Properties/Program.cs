using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var parameter = Console.ReadLine();

            CubeProperties(a, parameter);
        }

        static void CubeProperties(double a, string parameter)
        {
            switch (parameter)
            {
                case "face": Console.WriteLine("{0:F2}", Math.Sqrt(2) * a); break;
                case "space": Console.WriteLine("{0:F2}", Math.Sqrt(3) * a); break;
                case "volume": Console.WriteLine("{0:F2}", a * a * a); break;
                case "area": Console.WriteLine("{0:F2}", (a * a) * 6); break;
                default: break;
            }
        }
    }
}
