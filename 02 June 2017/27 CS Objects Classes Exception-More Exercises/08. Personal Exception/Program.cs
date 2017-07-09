using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Personal_Exception
{
    class Program
    {
        class ClassPersonalException : Exception
        {
            public ClassPersonalException() : base("My first exception is awesome!!!")
            {

            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                var input = int.Parse(Console.ReadLine());

                try
                {
                    if (input < 0)
                        throw new ClassPersonalException();

                    Console.WriteLine(input);
                }
                catch (ClassPersonalException cpe)
                {
                    Console.WriteLine(cpe.Message);
                    return;
                }
            }
        }
    }
}
