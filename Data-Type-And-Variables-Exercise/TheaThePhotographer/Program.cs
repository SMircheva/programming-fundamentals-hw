using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPics = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int timePerUpload = int.Parse(Console.ReadLine());

            long goodPics = (long)(Math.Ceiling(numberOfPics * filterFactor / 100));
            long totalTime = (long)(numberOfPics * filterTime + goodPics * timePerUpload);

            long days = totalTime / (24 * 60 * 60);
            totalTime = totalTime % (24 * 60 * 60);
            long hours = (totalTime) / (60 * 60);
            totalTime = totalTime % (60 * 60);
            long minutes = totalTime / 60;
            totalTime = totalTime % 60;
            long seconds = totalTime;

            Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
