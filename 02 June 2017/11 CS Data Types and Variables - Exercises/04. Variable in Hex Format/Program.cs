﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            Console.WriteLine($"{Convert.ToInt32(s1, 16)}");
        }
    }
}
