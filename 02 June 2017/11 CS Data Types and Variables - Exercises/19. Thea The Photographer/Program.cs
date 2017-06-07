using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var filterTime = int.Parse(Console.ReadLine());
            var filterFactor = int.Parse(Console.ReadLine());
            var uploadTime = int.Parse(Console.ReadLine());

            var nFilterTime = (long)n * filterTime;
            var goodPictures = Math.Ceiling(n / 100d * filterFactor);
            var goodPicturesUploadTime = (long)goodPictures * uploadTime;
            var totalTime = nFilterTime + goodPicturesUploadTime;

            TimeSpan time = TimeSpan.FromSeconds(totalTime);

            Console.WriteLine(time.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
