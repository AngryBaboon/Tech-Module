using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05.Write_to_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllText(@"..\..\sample_text.txt");

            var output = input.Split(new char[] { '.', ',', '!', '?', ':', }, StringSplitOptions.RemoveEmptyEntries);

            File.WriteAllText("output.txt", string.Join("", output));
        }
    }
}
